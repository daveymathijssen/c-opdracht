using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace NetworkLibrary
{
    [Serializable]
    public class Session
    {
        public DateTime startedDate { get; private set; }
        //public List<Measurement> measurements = new List<Measurement>();

        public Session(DateTime startedDate)
        {
            this.startedDate = startedDate;
        }

        //deserialization function
        public Session(SerializationInfo info, StreamingContext ctxt)
        {
            try
            {
                startedDate = (DateTime)info.GetValue("startedDate", typeof(DateTime));
                //measurements = (List<Measurement>)info.GetValue("measurements", typeof(List<Measurement>));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //serialize method
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("startedDate", startedDate);
        }
    }
}
