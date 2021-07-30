using System;
using System.IO;

namespace CheckNationalityGame.Repositories
{
    public class Providers
    {
        public string GenerateRandomPic()
        {

            string[] Pictures = Directory.GetFiles(@"RandomPic\", "*.*");
            return (GetPicPath() + "\\" + Pictures[GenerateRandomNum(Pictures.Length)]);
        }
        public string GetPicPath()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        }
        public int GenerateRandomNum(int maxLenght)
        {
            Random RondNum = new Random();
            return RondNum.Next(0, maxLenght);
        }
    }
}
