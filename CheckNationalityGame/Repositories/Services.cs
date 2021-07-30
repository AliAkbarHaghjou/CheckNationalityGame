using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CheckNationalityGame.Repositories
{
    public class Services
    {
        private Point LocJapanese { get; set; }
        private Point LocChinnes { get; set; }
        private Point LocKorean { get; set; }
        private Point LocThai { get; set; }

        public Services(Point locJapanese, Point locChinnes, Point locKorean, Point locThai)
        {
            LocJapanese = locJapanese;
            LocChinnes = locChinnes;
            LocKorean = locKorean;
            LocThai = locThai;
        }

        public bool CorrectSelected(string SourceLoc, string DestinationLoc)
        {
            if (SourceLoc.Contains(DestinationLoc))
                return true;
            else
                return false;
        }

        public string CalculateRating(int CurrentRate, bool UserSelection)
        {
            if (UserSelection == true)
            {
                return (CurrentRate + 20).ToString();
            }
            else
            {
                return (CurrentRate - 5).ToString();
            }
        }

        public string GetCorrectDirection(Point PicLoc)
        {

            List<Nationalities> nationalitiesList = new List<Nationalities>
            {
               new Nationalities {Nationality = "LocChinese",DistinceToBox = GetPointDistance(PicLoc, LocChinnes)},
               new Nationalities {Nationality = "LocJapanese", DistinceToBox = GetPointDistance(PicLoc, LocJapanese)},
               new Nationalities {Nationality = "LocKorean",DistinceToBox = GetPointDistance(PicLoc, LocKorean) },
               new Nationalities {Nationality = "LocThai",DistinceToBox = GetPointDistance(PicLoc, LocThai) }
            };

            return nationalitiesList.Where(x => x.DistinceToBox == (nationalitiesList.Min(p => p.DistinceToBox))).ToList()[0].Nationality;
        }

        public double GetPointDistance(Point source, Point destination)
        {
            var X = Math.Abs(source.X - destination.X);
            var Y = Math.Abs(source.Y - destination.Y);
            var PowerX = Math.Pow(X, 2);
            var PowerY = Math.Pow(Y, 2);
            return Math.Sqrt(PowerX + PowerY);
        }
    }
}
