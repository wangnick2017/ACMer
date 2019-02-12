using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMer.BackendLibrary
{
    [Serializable]
    public class Ticket
    {
        public WString TrainID;
        public DateTime Date;
        public int TicketNum;
        public int TicketID;
        public int Start, End, Kind;

        public Ticket(string trainID = "", DateTime date = default(DateTime), int ticketNum = 0, int ticketID = 0, int start = 0, int end = 0, int kind = 0)
        {
            TrainID = new WString(KeySize.Train, trainID);
            Date = date;
            TicketNum = ticketNum;
            TicketID = ticketID;
            Start = start;
            End = end;
            Kind = kind;
        }
    }

    public class TicketDetail
    {
        public string TrainID;
        public string LocFrom, LocTo;
        public DateTime DateFrom, DateTo;
        public string[] PriceNames;
        public int[] PriceNums;
        public double[] Prices;
        public int Cnt;

        public TicketDetail()
        {
            PriceNames = new string[12];
            PriceNums = new int[12];
            Prices = new double[12];
        }
    }

    [Serializable]
    public class TicketCnt
    {
        public int[][] c;
        public TicketCnt()
        {
            c = new int[12][];
            for (int i = 0; i < 12; ++i)
            {
                c[i] = new int[40];
                for (int j = 0; j < 40; ++j)
                    c[i][j] = 2000;
            }
        }
    }
}
