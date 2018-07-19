using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DisneyFilmList.Models;

namespace DisneyFilmList.DAL
{
    public class FilmListInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<FilmListContext>
    {
        protected override void Seed(FilmListContext context)
        {
            var movies = new List<Movie>
            {
            new Movie {Title="Snow White and the Seven Dwarfs",ReleaseDate=DateTime.Parse("1937-12-21"), Star = new Star{ Name="Adriana Caselotti" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Pinocchio",ReleaseDate=DateTime.Parse("1940-02-07"), Star = new Star{ Name="Dick Jones" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Fantasia",ReleaseDate=DateTime.Parse("1940-11-13"), Star = new Star{ Name="Leopold Stokowski" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Dumbo",ReleaseDate=DateTime.Parse("1941-10-23"), Star = new Star{ Name="Edward Brophy" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Bambi",ReleaseDate=DateTime.Parse("1942-08-13"), Star = new Star{ Name="Donnie Dunagan" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="The Three Caballeros",ReleaseDate=DateTime.Parse("1945-02-03"), Star = new Star{ Name="Clarence Nash" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Make Mine Music",ReleaseDate=DateTime.Parse("1946-04-20"), Star = new Star{ Name="Nelson Eddy" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Fun and Fancy Free",ReleaseDate=DateTime.Parse("1947-09-27"), Star = new Star{ Name="Cliff Edwards" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Melody Time",ReleaseDate=DateTime.Parse("1948-05-27"), Star = new Star{ Name="Roy Rogers" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="The Adventures of Ichabod and Mr. Toad",ReleaseDate=DateTime.Parse("1949-10-05"), Star = new Star{ Name="Bing Crosby" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Cinderella",ReleaseDate=DateTime.Parse("1950-02-15"), Star = new Star{ Name="Ilene Woods" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Alice in Wonderland",ReleaseDate=DateTime.Parse("1951-07-28"), Star = new Star{ Name="Kathryn Beaumont " }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Peter Pan",ReleaseDate=DateTime.Parse("1953-02-05"), Star = new Star{ Name="Bobby Driscoll" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Lady and the Tramp",ReleaseDate=DateTime.Parse("1955-06-22"), Star = new Star{ Name="Peggy Lee" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Sleeping Beauty",ReleaseDate=DateTime.Parse("1959-01-29"), Star = new Star{ Name="Mary Costa" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="One Hundred and One Dalmatians",ReleaseDate=DateTime.Parse("1961-01-25"), Star = new Star{ Name="Rod Taylor" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="The Sword in the Stone",ReleaseDate=DateTime.Parse("1963-03-12"), Star = new Star{ Name="Rickie Sorensen" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="Mary Poppins",ReleaseDate=DateTime.Parse("1964-08-29"), Star = new Star{ Name="Julie Andrews" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="The Jungle Book",ReleaseDate=DateTime.Parse("1967-10-18"), Star = new Star{ Name="Bruce Reitherman" }, Producer = new Producer{Name="Walt Disney"}},
            new Movie {Title="The Aristocats",ReleaseDate=DateTime.Parse("1970-12-24"), Star = new Star{ Name="Eva Gabor" }, Producer = new Producer{Name="Winston Hibler"}},
            new Movie {Title="Robin Hood",ReleaseDate=DateTime.Parse("1973-11-08"), Star = new Star{ Name="Phil Harris" }, Producer = new Producer{Name="Wolfgang Reitherman"}},
            new Movie {Title="The Many Adventures of Winnie the Pooh",ReleaseDate=DateTime.Parse("1977-03-11"), Star = new Star{ Name="Sterling Holloway" }, Producer = new Producer{Name="Wolfgang Reitherman"}},
            new Movie {Title="The Rescuers",ReleaseDate=DateTime.Parse("1977-06-22"), Star = new Star{ Name="Bob Newhart" }, Producer = new Producer{Name="Wolfgang Reitherman"}},
            new Movie {Title="Pete's Dragon",ReleaseDate=DateTime.Parse("1977-11-03"), Star = new Star{ Name="Helen Reddy" }, Producer = new Producer{Name="Jerome Courtland"}},
            new Movie {Title="The Fox and the Hound",ReleaseDate=DateTime.Parse("1981-07-10"), Star = new Star{ Name="Mickey Rooney" }, Producer = new Producer{Name="Ron Miller"}},
            new Movie {Title="Tron",ReleaseDate=DateTime.Parse("1982-07-09"), Star = new Star{ Name="Jeff Bridges" }, Producer = new Producer{Name="Donald Kushner"}},
            new Movie {Title="The Black Cauldron",ReleaseDate=DateTime.Parse("1985-07-24"), Star = new Star{ Name="Grant Bardsley" }, Producer = new Producer{Name="Joe Hale"}},
            new Movie {Title="The Great Mouse Detective",ReleaseDate=DateTime.Parse("1986-07-02"), Star = new Star{ Name="Vincent Price" }, Producer = new Producer{Name="Burny Mattinson"}},
            new Movie {Title="Who Framed Roger Rabbit",ReleaseDate=DateTime.Parse("1988-06-22"), Star = new Star{ Name="Charles Fleischer" }, Producer = new Producer{Name="Frank Marshall"}},
            new Movie {Title="Oliver & Company",ReleaseDate=DateTime.Parse("1988-11-18"), Star = new Star{ Name="Joey Lawrence" }, Producer = new Producer{Name="Walt Disney Feature Animation"}}
            };
            //System.DateTime.Today.ToShortDateString()

            movies.ForEach(m => context.Movies.Add(m));

            context.Stars.Add(movies[0].Star);
            context.Producers.Add(movies[0].Producer);

            context.SaveChanges();
            
            //var producers = new List<Producer>
            //{
            //    //new Producer{Name="Walt Disney",MovieID=1,StarID=1937},
            //    //new Producer{Name="Walt Disney",MovieID=2,StarID=1940},
            //    //new Producer{Name="Walt Disney",MovieID=3,StarID=1941},
            //    //new Producer{Name="Walt Disney",MovieID=4,StarID=1942},
            //    //new Producer{Name="Walt Disney",MovieID=5,StarID=1946},
            //    //new Producer{Name="Walt Disney",MovieID=6,StarID=1949},
            //    //new Producer{Name="Walt Disney",MovieID=7,StarID=1950},
            //    //new Producer{Name="Walt Disney",MovieID=8,StarID=1953},
            //};
            //producers.ForEach(m => context.Producers.Add(m));
            //context.SaveChanges();
        }
    }
}