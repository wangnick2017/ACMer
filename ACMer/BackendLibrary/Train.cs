using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMer.BackendLibrary
{
    public class StationView
    {
        public string Name
        {
            get;
            set;
        }
        public string P一等座
        {
            get;
            set;
        }
        public string P二等座
        {
            get;
            set;
        }
        public string P特等座
        {
            get;
            set;
        }
        public string P商务座
        {
            get;
            set;
        }
        public string P软卧
        {
            get;
            set;
        }
        public string P硬卧
        {
            get;
            set;
        }
        public string P高级软卧
        {
            get;
            set;
        }
        public string P无座
        {
            get;
            set;
        }
        public string P软座
        {
            get;
            set;
        }
        public string P硬座
        {
            get;
            set;
        }

        public int ArriveDay
        {
            get;
            set;
        }
        public int ArriveHour
        {
            get;
            set;
        }
        public int ArriveMinute
        {
            get;
            set;
        }

        public int StartDay
        {
            get;
            set;
        }
        public int StartHour
        {
            get;
            set;
        }
        public int StartMinute
        {
            get;
            set;
        }
    }

    [Serializable]
    public class Station
    {
        public WString Name;
        public TimeSpan TimeArrive, TimeStart;
        public double[] Prices;

        public Station(string name = "", TimeSpan timeArrive = default(TimeSpan), TimeSpan timeStart = default(TimeSpan), double[] prices = null)
        {
            Name = new WString(10, name);
            TimeArrive = timeArrive == null ? new TimeSpan() : timeArrive;
            TimeStart = timeStart == null ? new TimeSpan() : timeStart;
            Prices = new double[12];
            if (prices == null)
                return;
            for (int i = 0, j = prices.Length; i < 12; ++i)
                Prices[i] = i < j ? prices[i] : 0;
        }
    }

    [Serializable]
    public class Train
    {
        public WString TrainID, Name;
        public WString[] PriceNames;
        public char Catalog;
        public bool Sold;
        public int StationNum, PriceNum;
        public Station[] Stations;

        public Train(string trainID = "", string name = "", char catalog = '\0', string[] priceNames = null, Station[] stations = null)
        {
            TrainID = new WString(10, trainID);
            Name = new WString(10, name);
            Catalog = catalog;
            PriceNum = priceNames == null ? 0 : priceNames.Length;
            PriceNames = new WString[12];
            for (int i = 0; i < 12; ++i)
            {
                PriceNames[i] = new WString(10, i < PriceNum ? priceNames[i] : "");
            }
            StationNum = stations == null ? 0 : stations.Length;
            Stations = new Station[30];
            for (int i = 0; i < 30; ++i)
            {
                Stations[i] = i < StationNum ? stations[i] : new Station();
            }
        }
    }
}
