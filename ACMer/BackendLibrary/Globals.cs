using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ACMer.BackendLibrary
{
    public static class ObjectSize
    {
        public static int User = 0, Train = 0, Ticket = 0, Route = 0, Station = 0, TicketCnt = 0;
        public static void InitSizes()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                int length = 0;

                User user = new User();
                bf.Serialize(stream, user);
                User = stream.ToArray().Length;
                length += User;

                Train train = new Train();
                bf.Serialize(stream, train);
                Train = stream.ToArray().Length - length;
                length += Train;

                Ticket ticket = new Ticket();
                bf.Serialize(stream, ticket);
                Ticket = stream.ToArray().Length - length;
                length += Ticket;

                int testInt = 20190204;
                bf.Serialize(stream, testInt);
                Route = Station = stream.ToArray().Length - length;
                length += Route;

                TicketCnt ticketCnt = new TicketCnt();
                bf.Serialize(stream, ticketCnt);
                TicketCnt = stream.ToArray().Length - length;
                length += TicketCnt;
            }
        }
    }

    public static class KeySize
    {
        public static int Train = 10, Route = 40, Ticket = 40, Station = 10, TicketCnt = 30;
    }
}
