namespace Converter
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
            string returnString = "";
            foreach(char item in dna){
                if(item.CompareTo('T') == 0){
                    returnString += 'U';
                }
                else{
                    returnString += item;
                }
            }
            return returnString;
        }
    }
}