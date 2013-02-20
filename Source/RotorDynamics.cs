using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RDTextParser;

namespace RotorDynamics.Source
{
    class RotorDynamics
    {
        public List<KeyValuePair<String, String>> TurbineShaft01;
        TextParser txtParser = new TextParser("D:\\temp\\RotorDynamics\\RotorDynamics\\Output\\TurbineShaft01.txt");
        public RotorDynamics()
        {
            TurbineShaft01 = new List<KeyValuePair<string, string>>();
        }
        public void AddToTurbineShaft01(String Key, String Value)
        {
            TurbineShaft01.Add(new KeyValuePair<String, String>(Key, Value));
        }
        public void SaveTurbineShaft01()
        {
            foreach( KeyValuePair<String, String> KVp in TurbineShaft01)
            {
                txtParser.TextParserWriteValue("Test", KVp.Key, KVp.Value);
            }
        }
        public string GetTurbineShaft01(String Key)
        {
            return txtParser.TextParserReadValue("Test", Key);
        }
    }
}
