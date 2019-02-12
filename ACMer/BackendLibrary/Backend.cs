using System;
using System.Collections.Generic;

namespace ACMer.BackendLibrary
{
    public class Backend : IDisposable
    {
        public string ErrorMessage;

        Vector<User> DBUser;
        Database<WString, Train> DBTrain;
        Database<WString, int> DBRoute;
        Database<WString, Ticket> DBTicket;
        Database<WString, int> DBStation;
        Database<WString, TicketCnt> DBTicketCnt;

        public Backend()
        {
            DBUser = new Vector<User>();
            DBTrain = new Database<WString, Train>();
            DBRoute = new Database<WString, int>();
            DBTicket = new Database<WString, Ticket>();
            DBStation = new Database<WString, int>();
            DBTicketCnt = new Database<WString, TicketCnt>();
        }

        public void Init()
        {
            DBUser.Init("user", ObjectSize.User);
            DBTrain.Init("train", ObjectSize.Train);
            DBRoute.Init("route", ObjectSize.Route);
            DBTicket.Init("ticket", ObjectSize.Ticket);
            DBStation.Init("station", ObjectSize.Station);
            DBTicketCnt.Init("cnt", ObjectSize.TicketCnt);
            WString foo = new WString(KeySize.Ticket);
            var bar = DBTicket.Find(foo);
            if (!bar.Item2)
            {
                Ticket tmp = new Ticket();
                DBTicket.Insert(foo, tmp);
            }
        }

        public void Clear()
        {
            DBUser.Trunc();
            DBTrain.Trunc();
            DBRoute.Trunc();
            DBTicket.Trunc();
            DBStation.Trunc();
            DBTicketCnt.Trunc();
        }

        public Tuple<int, int> Register(User user)
        {
            user.UserID = 2018 + DBUser.Size;
            user.Privilege = user.UserID == 2018 ? 2 : 1;
            DBUser.Insert(user);
            return new Tuple<int, int>(user.UserID, user.Privilege);
        }

        public User Login(int id, string password)
        {
            var bar = DBUser.Find(id - 2018);
            if (!bar.Item2 || bar.Item1.Password != password)
                return default(User);
            return bar.Item1;
        }

        public User QueryProfile(int id)
        {
            var bar = DBUser.Find(id - 2018);
            if (!bar.Item2)
                return default(User);
            return bar.Item1;
        }

        public bool ModifyProfile(User user)
        {
            var bar = DBUser.Find(user.UserID - 2018);
            if (!bar.Item2)
                return false;
            user.Privilege = bar.Item1.Privilege;
            DBUser.Modify(user.UserID - 2018, user);
            return true;
        }

        public bool ModifyPrivilege(int id1, int id2, int privilege)
        {
            var bar1 = DBUser.Find(id1 - 2018);
            var bar2 = DBUser.Find(id2 - 2018);
            if (!bar1.Item2 || !bar2.Item2 || bar1.Item1.Privilege != 2 || bar2.Item1.Privilege > privilege)
                return false;
            bar2.Item1.Privilege = privilege;
            DBUser.Modify(id2 - 2018, bar2.Item1);
            return true;
        }

        public bool AddTrain(Train train)
        {
            train.Sold = false;
            return DBTrain.Insert(train.TrainID, train);
        }

        public Train QueryTrain(string trainID)
        {
            var bar = DBTrain.Find(new WString(KeySize.Train, trainID));
            if (!bar.Item2)
                return default(Train);
            else
                return bar.Item1;
        }

        public bool ModifyTrain(Train train)
        {
            var bar = DBTrain.Find(train.TrainID);
            if (!bar.Item2 || bar.Item1.Sold)
                return false;
            return DBTrain.Modify(train.TrainID, train);
        }

        public bool RemoveTrain(WString trainID)
        {
            var bar = DBTrain.Find(trainID);
            if (!bar.Item2 || bar.Item1.Sold)
                return false;
            return DBTrain.Remove(trainID);
        }

        public bool SellTrain(WString trainID)
        {
            var bar = DBTrain.Find(trainID);
            if (!bar.Item2 || bar.Item1.Sold)
                return false;
            Train train = bar.Item1;
            train.Sold = true;
            DBTrain.Modify(trainID, train);
            for (int i = 0; i < train.StationNum; ++i)
            {
                DBStation.Insert(new WString(KeySize.Station, train.Stations[i].Name.ToString()), 1);
                for (int j = i + 1; j < train.StationNum; ++j)
                {
                    DBRoute.Insert(new WString(KeySize.Route, train.Stations[i].Name.ToString() + train.Stations[j].Name.ToString() + train.TrainID.ToString()), 1);
                }
            }
            return true;
        }

        public List<TicketDetail> QueryTicket(string loc1, string loc2, DateTime date, string catalogs)
        {
            WString route1 = new WString(KeySize.Route, loc1 + loc2 + new String(Char.MinValue, 20));
            WString route2 = new WString(KeySize.Route, loc1 + loc2 + new String(Char.MaxValue, 20));
            List<WString> list = DBRoute.FindRange(route1, route2);
            int tl = loc1.Length + loc2.Length;
            int total = 0;
            List<TicketDetail> ret = new List<TicketDetail>();
            for (int i = 0; i < list.Count; ++i)
            {
                int cl = list[i].Length;
                WString trainID = new WString(KeySize.Train);
                for (int j = tl; j < cl; ++j)
                    trainID[j - tl] = list[i][j];
                trainID.Length = cl - tl;
                var bar = DBTrain.Find(trainID);
                if (!bar.Item2)
                    continue;
                bool flag = false;
                for (int j = 0; j < catalogs.Length; ++j)
                    if (catalogs[j] == bar.Item1.Catalog)
                    {
                        flag = true;
                        break;
                    }
                if (!flag)
                    continue;
                TicketDetail detail = new TicketDetail
                {
                    TrainID = trainID.ToString(),
                    LocFrom = loc1
                };
                int t1 = 0, t2 = 0;
                for (int j = 0; j < bar.Item1.StationNum; ++j)
                {
                    if (bar.Item1.Stations[j].Name == loc1)
                    {
                        detail.DateFrom = date + bar.Item1.Stations[j].TimeStart;
                        detail.LocTo = loc2;
                        t1 = j;
                    }
                    else if (bar.Item1.Stations[j].Name == loc2)
                    {
                        detail.DateTo = date + bar.Item1.Stations[j].TimeStart;
                        t2 = j;
                        break;
                    }
                }
                detail.Cnt = bar.Item1.PriceNum;
                for (int j = 0; j < detail.Cnt; ++j)
                {
                    detail.PriceNames[j] = bar.Item1.PriceNames[j].ToString();
                    WString tk = new WString(KeySize.TicketCnt, bar.Item1.TrainID + date.ToString("yyyy-MM-dd"));
                    var bar2 = DBTicketCnt.Find(tk);
                    detail.PriceNums[j] = 2000;
                    if (!bar2.Item2)
                    {
                        TicketCnt tmp = new TicketCnt();
                        DBTicketCnt.Insert(tk, tmp);
                    }
                    else
                    {
                        for (int k = t1 + 1; k <= t2; ++k)
                            detail.PriceNums[j] = Math.Min(detail.PriceNums[j], bar2.Item1.c[j][k]);
                    }
                    detail.Prices[j] = 0;
                    for (int k = t1 + 1; k <= t2; ++k)
                        detail.Prices[j] += bar.Item1.Stations[k].Prices[j];
                }
                ret.Add(detail);
                ++total;
            }
            return ret;
        }

        Tuple<TimeSpan, WString> Qtt(string loc1, string loc2, DateTime date, string catalogs, TimeSpan time)
        {
            WString route1 = new WString(KeySize.Route, loc1 + loc2 + new String(Char.MinValue, 20));
            WString route2 = new WString(KeySize.Route, loc1 + loc2 + new String(Char.MaxValue, 20));
            List<WString> list = DBRoute.FindRange(route1, route2);
            int tl = loc1.Length + loc2.Length;
            WString ansID = new WString(KeySize.Train);
            TimeSpan ans = TimeSpan.MaxValue;
            for (int i = 0; i <list.Count; ++i)
            {
                int cl = list[i].Length;
                WString trainID = new WString(KeySize.Train);
                for (int j = tl; j < cl; ++j)
                    trainID[j - tl] = list[i][j];
                trainID.Length = cl - tl;
                var bar = DBTrain.Find(trainID);
                if (!bar.Item2)
                    continue;
                bool flag = false;
                for (int j = 0; j < catalogs.Length; ++j)
                    if (catalogs[j] == bar.Item1.Catalog)
                    {
                        flag = true;
                        break;
                    }
                if (!flag)
                    continue;
                TimeSpan ttime = new TimeSpan();
                for (int j = 0; j < bar.Item1.StationNum; ++j)
                {
                    if (bar.Item1.Stations[j].Name == loc1)
                    {
                        if (bar.Item1.Stations[j].TimeStart < time)
                            ttime.Add(new TimeSpan(1, 0, 0, 0));
                    }
                    else if (bar.Item1.Stations[j].Name == loc2)
                    {
                        ttime.Add(bar.Item1.Stations[j].TimeArrive);
                    }
                }
                if (ttime < ans && ttime >= time)
                {
                    ans = ttime;
                    ansID = trainID;
                }
            }
            return new Tuple<TimeSpan, WString>(ans, ansID);
        }

        public List<TicketDetail> QueryTransfer(string loc1, string loc2, DateTime date, string catalogs)
        {
            TimeSpan ans = TimeSpan.MaxValue;
            List<WString> list = DBStation.FindRange(new WString(KeySize.Station, Char.MinValue), new WString(KeySize.Station, Char.MaxValue));
            WString id1 = new WString(), id2 = new WString(), trans = new WString();
            for (int i = 0; i < list.Count; ++i)
            {
                TimeSpan tmp = new TimeSpan();
                var bar1 = Qtt(loc1, list[i].ToString(), date, catalogs, tmp);
                var bar2 = Qtt(list[i].ToString(), loc2, date, catalogs, bar1.Item1);
                if (bar2.Item1 < ans)
                {
                    ans = bar2.Item1;
                    id1 = bar1.Item2;
                    id2 = bar2.Item2;
                    trans = list[i];
                }
            }
            List<TicketDetail> ret = new List<TicketDetail>();
            if (id1.Length == 0 || id2.Length == 0 || ans == TimeSpan.MaxValue)
                return ret;

            var bar = DBTrain.Find(id1);
            TicketDetail detail = new TicketDetail
            {
                TrainID = id1.ToString(),
                LocFrom = loc1
            };
            int t1 = 0, t2 = 0;
            DateTime timeTrans = new DateTime();
            for (int j = 0; j < bar.Item1.StationNum; ++j)
            {
                if (bar.Item1.Stations[j].Name == loc1)
                {
                    detail.DateFrom = date + bar.Item1.Stations[j].TimeStart;
                    detail.LocTo = trans.ToString();
                    t1 = j;
                }
                else if (bar.Item1.Stations[j].Name == trans.ToString())
                {
                    timeTrans = detail.DateTo = date + bar.Item1.Stations[j].TimeStart;
                    t2 = j;
                    break;
                }
            }
            detail.Cnt = bar.Item1.PriceNum;
            for (int j = 0; j < detail.Cnt; ++j)
            {
                detail.PriceNames[j] = bar.Item1.PriceNames[j].ToString();
                WString tk = new WString(KeySize.TicketCnt, bar.Item1.TrainID + date.ToString("yyyy-MM-dd"));
                var bar2 = DBTicketCnt.Find(tk);
                detail.PriceNums[j] = 2000;
                if (!bar2.Item2)
                {
                    TicketCnt tmp = new TicketCnt();
                    DBTicketCnt.Insert(tk, tmp);
                }
                else
                {
                    for (int k = t1 + 1; k <= t2; ++k)
                        detail.PriceNums[j] = Math.Min(detail.PriceNums[j], bar2.Item1.c[j][k]);
                }
                detail.Prices[j] = 0;
                for (int k = t1 + 1; k <= t2; ++k)
                    detail.Prices[j] += bar.Item1.Stations[k].Prices[j];
            }
            ret.Add(detail);

            bar = DBTrain.Find(id2);
            detail = new TicketDetail
            {
                TrainID = id2.ToString(),
                LocFrom = trans.ToString()
            };
            t1 = 0;
            t2 = 0;
            for (int j = 0; j < bar.Item1.StationNum; ++j)
            {
                if (bar.Item1.Stations[j].Name == trans.ToString())
                {
                    while (date + bar.Item1.Stations[j].TimeStart < timeTrans)
                        date.AddDays(1);
                    detail.DateFrom = date + bar.Item1.Stations[j].TimeStart;
                    detail.LocTo = loc2;
                    t1 = j;
                }
                else if (bar.Item1.Stations[j].Name == loc2)
                {
                    detail.DateTo = date + bar.Item1.Stations[j].TimeStart;
                    t2 = j;
                    break;
                }
            }
            detail.Cnt = bar.Item1.PriceNum;
            for (int j = 0; j < detail.Cnt; ++j)
            {
                detail.PriceNames[j] = bar.Item1.PriceNames[j].ToString();
                WString tk = new WString(KeySize.TicketCnt, bar.Item1.TrainID + date.ToString("yyyy-MM-dd"));
                var bar2 = DBTicketCnt.Find(tk);
                detail.PriceNums[j] = 2000;
                if (!bar2.Item2)
                {
                    TicketCnt tmp = new TicketCnt();
                    DBTicketCnt.Insert(tk, tmp);
                }
                else
                {
                    for (int k = t1 + 1; k <= t2; ++k)
                        detail.PriceNums[j] = Math.Min(detail.PriceNums[j], bar2.Item1.c[j][k]);
                }
                detail.Prices[j] = 0;
                for (int k = t1 + 1; k <= t2; ++k)
                    detail.Prices[j] += bar.Item1.Stations[k].Prices[j];
            }
            ret.Add(detail);
            return ret;
        }

        public bool BuyTicket(int userID, int num, string trainID, string loc1, string loc2, DateTime date, string kind)
        {
            var bar = DBTrain.Find(new WString(KeySize.Train, trainID));
            if (!bar.Item2)
                return false;
            int t1 = -1, t2 = -1, tkind = -1;
            for (int i = 0; i < bar.Item1.StationNum; ++i)
            {
                if (bar.Item1.Stations[i].Name == loc1)
                    t1 = i;
                if (bar.Item1.Stations[i].Name == loc2)
                    t2 = i;
            }
            for (int i = 0; i < bar.Item1.PriceNum; ++i)
                if (bar.Item1.PriceNames[i] == kind)
                    tkind = i;
            if (t1 < 0 || t2 < 0 || t1 >= t2 || tkind < 0)
                return false;
            WString tk = new WString(KeySize.TicketCnt, bar.Item1.TrainID + date.ToString("yyyy-MM-dd"));
            var bar2 = DBTicketCnt.Find(tk);
            if (!bar2.Item2)
            {
                TicketCnt tmp = new TicketCnt();
                DBTicketCnt.Insert(tk, tmp);
            }
            for (int i = t1 + 1; i <= t2; ++i)
            {
                if (bar2.Item1.c[tkind][i] < num)
                    return false;
                bar2.Item1.c[tkind][i] -= num;
            }
            DBTicketCnt.Modify(tk, bar2.Item1);

            WString foo = new WString(KeySize.Ticket);
            var bar3 = DBTicket.Find(foo);
            int tn = ++bar3.Item1.TicketID;
            DBTicket.Modify(foo, bar3.Item1);
            WString STicket = new WString(KeySize.Ticket, userID.ToString() + date.ToString("yyyy-MM-dd") + bar.Item1.Catalog + tn.ToString("D9"));
            Ticket ticket = new Ticket(trainID, date, num, tn, t1, t2, tkind);
            DBTicket.Insert(STicket, ticket);
            return true;
        }

        public List<TicketDetail> QueryOrder(int userID, DateTime date, string catalogs)
        {
            List<TicketDetail> ret = new List<TicketDetail>();
            for (int l = 0; l < catalogs.Length; ++l)
            {
                WString STic1 = new WString(KeySize.Ticket, userID.ToString() + date.ToString("yyyy-MM-dd") + catalogs[l] + "000000000");
                WString STic2 = new WString(KeySize.Ticket, userID.ToString() + date.ToString("yyyy-MM-dd") + catalogs[l] + "999999999");
                var list = DBTicket.FindRangeData(STic1, STic2);
                for (int i = 0, sz = list.Count; i < sz; ++i)
                {
                    TicketDetail detail = new TicketDetail();
                    var bar = DBTrain.Find(list[i].TrainID);
                    detail.TrainID = list[i].TrainID.ToString();
                    detail.LocFrom = bar.Item1.Stations[list[i].Start].Name.ToString();
                    detail.DateFrom = list[i].Date + bar.Item1.Stations[list[i].Start].TimeStart;
                    detail.LocTo = bar.Item1.Stations[list[i].End].Name.ToString();
                    detail.DateTo = list[i].Date + bar.Item1.Stations[list[i].End].TimeArrive;
                    detail.Cnt = bar.Item1.PriceNum;
                    for (int j = 0; j < detail.Cnt; ++j)
                    {
                        detail.PriceNames[j] = bar.Item1.PriceNames[j].ToString();
                        detail.PriceNums[j] = j == list[i].Kind ? list[i].TicketNum : 0;
                        detail.Prices[j] = 0;
                        for (int k = list[i].Start + 1; k <= list[i].End; ++k)
                            detail.Prices[j] += bar.Item1.Stations[k].Prices[j];
                    }
                    ret.Add(detail);
                }
            }
            return ret;
        }

        public bool RefundTicket(int userID, int num, string trainID, string loc1, string loc2, DateTime date, string kind)
        {
            var bar = DBTrain.Find(new WString(KeySize.Train, trainID));
            if (!bar.Item2)
                return false;
            char catalog = bar.Item1.Catalog;
            string stic = userID.ToString() + date.ToString("yyyy-MM-dd") + catalog;
            var list = DBTicket.FindRangeData(new WString(KeySize.Ticket, stic + "000000000"), new WString(KeySize.Ticket, stic + "999999999"));
            int total = 0;
            for (int i = 0; i < list.Count; ++i)
                if (list[i].TrainID == trainID)
                {
                    if (bar.Item1.Stations[list[i].Start].Name != loc1 ||
                        bar.Item1.Stations[list[i].End].Name != loc2 ||
                        bar.Item1.PriceNames[list[i].Kind] != kind)
                        continue;
                    total += list[i].TicketNum;
                }
            if (total < num)
                return false;
            for (int i = 0; i < list.Count; ++i)
                if (list[i].TrainID == trainID)
                {
                    if (bar.Item1.Stations[list[i].Start].Name != loc1 ||
                        bar.Item1.Stations[list[i].End].Name != loc2 ||
                        bar.Item1.PriceNames[list[i].Kind] != kind)
                        continue;
                    if (num < list[i].TicketNum)
                    {
                        list[i].TicketNum -= num;
                        DBTicket.Modify(new WString(KeySize.Ticket, stic + list[i].TicketID.ToString("D9")), list[i]);
                        WString tc = new WString(KeySize.TicketCnt, bar.Item1.TrainID.ToString() + date.ToString("yyyy-MM-dd"));
                        var bar2 = DBTicketCnt.Find(tc);
                        for (int j = list[i].Start + 1; j <= list[i].End; ++j)
                            bar2.Item1.c[list[i].Kind][j] += num;
                        DBTicketCnt.Modify(tc, bar2.Item1);
                        num = 0;
                    }
                    else
                    {
                        num -= list[i].TicketNum;
                        DBTicket.Remove(new WString(KeySize.Ticket, stic + list[i].TicketID.ToString("D9")));
                        WString tc = new WString(KeySize.TicketCnt, bar.Item1.TrainID.ToString() + date.ToString("yyyy-MM-dd"));
                        var bar2 = DBTicketCnt.Find(tc);
                        for (int j = list[i].Start + 1; j <= list[i].End; ++j)
                            bar2.Item1.c[list[i].Kind][j] += list[i].TicketNum;
                        DBTicketCnt.Modify(tc, bar2.Item1);
                    }
                    if (num == 0)
                        break;
                }
            return true;
        }

        public void Dispose()
        {
            DBRoute.Dispose();
            DBStation.Dispose();
            DBTicket.Dispose();
            DBTicketCnt.Dispose();
            DBTrain.Dispose();
            DBUser.Dispose();
        }
    }
}
