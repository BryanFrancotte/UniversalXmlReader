using UniversalXmlReader;

namespace DemoApplication.logic
{
    public class Logic
    {
        public static void ExecuteLogic(string[] args){
            Reader.ReadAllValue(@"FichierConsolideSimple.xml");
        }
    }
}