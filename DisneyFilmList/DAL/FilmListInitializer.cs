﻿using System;
using System.Collections.Generic;
using DisneyFilmList.Models;

namespace DisneyFilmList.DAL
{
    public class FilmListInitializer : System.Data.Entity. DropCreateDatabaseAlways<FilmListContext>
    {
        //Where I chose to seed all the data
        protected override void Seed(FilmListContext context)
        {
            var movies = new List<Movie>()
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
            new Movie {Title="Oliver & Company",ReleaseDate=DateTime.Parse("1988-11-18"), Star = new Star{ Name="Joey Lawrence" }, Producer = new Producer{Name="Kathleen Gavin"}},
            new Movie {Title="The Little Mermaid",ReleaseDate=DateTime.Parse("1989-11-17"), Star = new Star{ Name="Jodi Benson" }, Producer = new Producer{Name="John Musker"}},
            new Movie {Title="DuckTales the Movie: Treasure of the Lost Lamp",ReleaseDate=DateTime.Parse("1990-08-03"), Star = new Star{ Name="Alan Young" }, Producer = new Producer{Name="Bob Hathcock"}},
            new Movie {Title="The Rescuers Down Under",ReleaseDate=DateTime.Parse("1990-11-16"), Star = new Star{ Name="John Candy" }, Producer = new Producer{Name="Thomas Schumacher"}},
            new Movie {Title="Beauty and the Beast",ReleaseDate=DateTime.Parse("1991-11-22"), Star = new Star{ Name="Paige O'Hara" }, Producer = new Producer{Name="Don Hahn"}},
            new Movie {Title="Aladdin",ReleaseDate=DateTime.Parse("1992-11-25"), Star = new Star{ Name="Robin Williams" }, Producer = new Producer{Name="Ron Clements"}},
            new Movie {Title="The Nightmare Before Christmas",ReleaseDate=DateTime.Parse("1993-10-29"), Star = new Star{ Name="Chris Sarandon" }, Producer = new Producer{Name="Tim Burton"}},
            new Movie {Title="The Lion King",ReleaseDate=DateTime.Parse("1994-06-24"), Star = new Star{ Name="Matthew Broderick" }, Producer = new Producer{Name="Don Hahn"}},
            new Movie {Title="A Goofy Movie",ReleaseDate=DateTime.Parse("1995-04-07"), Star = new Star{ Name="Bill Farmer" }, Producer = new Producer{Name="Dan Rounds"}},
            new Movie {Title="Pocahontas",ReleaseDate=DateTime.Parse("1995-06-23"), Star = new Star{ Name="Irene Bedard" }, Producer = new Producer{Name="Jim Pentecost"}},
            new Movie {Title="Toy Story",ReleaseDate=DateTime.Parse("1995-11-22"), Star = new Star{ Name="Tim Allen" }, Producer = new Producer{Name="Ralph Guggenheim"}},
            new Movie {Title="The Hunchback of Notre Dame",ReleaseDate=DateTime.Parse("1996-06-21"), Star = new Star{ Name="Tom Hulce" }, Producer = new Producer{Name="Don Hahn"}},
            new Movie {Title="Hercules",ReleaseDate=DateTime.Parse("1997-06-27"), Star = new Star{ Name="Tate Donovan" }, Producer = new Producer{Name="Alice Dewey"}},
            new Movie {Title="Mulan",ReleaseDate=DateTime.Parse("1998-06-19"), Star = new Star{ Name="Ming-Na Wen" }, Producer = new Producer{Name="Pam Coats"}},
            new Movie {Title="A Bug's Life",ReleaseDate=DateTime.Parse("1998-11-25"), Star = new Star{ Name="Dave Foley" }, Producer = new Producer{Name="Darla K. Anderson"}},
            new Movie {Title="Tarzan",ReleaseDate=DateTime.Parse("1999-06-16"), Star = new Star{ Name="Tony Goldwyn" }, Producer = new Producer{Name="Bonnie Arnold"}},
            new Movie {Title="Toy Story 2",ReleaseDate=DateTime.Parse("1999-11-24"), Star = new Star{ Name="Tom Hanks" }, Producer = new Producer{Name="Helene Plotkin"}},
            new Movie {Title="Fantasia 2000",ReleaseDate=DateTime.Parse("1999-12-17"), Star = new Star{ Name="James Levine" }, Producer = new Producer{Name="Roy E. Disney"}},
            new Movie {Title="The Tigger Movie",ReleaseDate=DateTime.Parse("2000-02-11"), Star = new Star{ Name="Jim Cummings" }, Producer = new Producer{Name="Cheryl Abood"}},
            new Movie {Title="Dinosaur",ReleaseDate=DateTime.Parse("2000-05-19"), Star = new Star{ Name="D. B. Sweeney" }, Producer = new Producer{Name="Pam Marsden"}},
            new Movie {Title="The Emperor's New Groove",ReleaseDate=DateTime.Parse("2000-12-15"), Star = new Star{ Name="David Spade" }, Producer = new Producer{Name="Randy Fullmer"}},
            new Movie {Title="Recess: School's Out",ReleaseDate=DateTime.Parse("2001-02-16"), Star = new Star{ Name="Andrew Lawrence" }, Producer = new Producer{Name="Joe Ansolabehere"}},
            new Movie {Title="Atlantis: The Lost Empire",ReleaseDate=DateTime.Parse("2001-06-15"), Star = new Star{ Name="Michael J. Fox" }, Producer = new Producer{Name="Don Hahn"}},
            new Movie {Title="Monsters, Inc.",ReleaseDate=DateTime.Parse("2001-11-02"), Star = new Star{ Name="John Goodman" }, Producer = new Producer{Name="Darla K. Anderson"}},
            new Movie {Title="Return to Never Land",ReleaseDate=DateTime.Parse("2002-02-15"), Star = new Star{ Name="Harriet Owen" }, Producer = new Producer{Name="Christopher Chase"}},
            new Movie {Title="Lilo & Stitch",ReleaseDate=DateTime.Parse("2002-06-21"), Star = new Star{ Name="Daveigh Chase" }, Producer = new Producer{Name="Clark Spencer"}},
            new Movie {Title="Treasure Planet",ReleaseDate=DateTime.Parse("2002-11-27"), Star = new Star{ Name="Joseph Gordon-Levitt" }, Producer = new Producer{Name="Roy Conli"}},
            new Movie {Title="The Jungle Book 2",ReleaseDate=DateTime.Parse("2003-02-14"), Star = new Star{ Name="Haley Joel Osment" }, Producer = new Producer{Name="Mary Thorne"}},
            new Movie {Title="Piglet's Big Movie",ReleaseDate=DateTime.Parse("2003-03-21"), Star = new Star{ Name="John Fiedler" }, Producer = new Producer{Name="Michelle Pappalardo-Robinson"}},
            new Movie {Title="Finding Nemo",ReleaseDate=DateTime.Parse("2003-05-30"), Star = new Star{ Name="Albert Brooks" }, Producer = new Producer{Name="Graham Walters"}},
            new Movie {Title="Brother Bear",ReleaseDate=DateTime.Parse("2003-11-01"), Star = new Star{ Name="Joaquin Phoenix" }, Producer = new Producer{Name="Chuck Williams"}},
            new Movie {Title="Teacher's Pet",ReleaseDate=DateTime.Parse("2004-01-16"), Star = new Star{ Name="Nathan Lane" }, Producer = new Producer{Name="Stephen Swofford"}},
            new Movie {Title="Home on the Range",ReleaseDate=DateTime.Parse("2004-04-02"), Star = new Star{ Name="Roseanne Barr" }, Producer = new Producer{Name="Alice Dewey Goldstone"}},
            new Movie {Title="The Incredibles",ReleaseDate=DateTime.Parse("2004-11-05"), Star = new Star{ Name="Craig T. Nelson" }, Producer = new Producer{Name="John Walker"}},
            new Movie {Title="Pooh's Heffalump Movie",ReleaseDate=DateTime.Parse("2005-02-11"), Star = new Star{ Name="Jim Cummings" }, Producer = new Producer{Name="Jessica Koplos-Miller"}},
            new Movie {Title="Valiant",ReleaseDate=DateTime.Parse("2005-08-19"), Star = new Star{ Name="Ewan McGregor" }, Producer = new Producer{Name="John H. Williams"}},
            new Movie {Title="Chicken Little",ReleaseDate=DateTime.Parse("2005-11-04"), Star = new Star{ Name="Zach Braff" }, Producer = new Producer{Name="Randy Fullmer"}},
            new Movie {Title="The Wild",ReleaseDate=DateTime.Parse("2006-04-14"), Star = new Star{ Name="Kiefer Sutherland" }, Producer = new Producer{Name="Clint Goldman"}},
            new Movie {Title="Cars",ReleaseDate=DateTime.Parse("2006-06-09"), Star = new Star{ Name="Owen Wilson" }, Producer = new Producer{Name="Darla K. Anderson"}},
            new Movie {Title="Meet the Robinsons",ReleaseDate=DateTime.Parse("2007-03-30"), Star = new Star{ Name="Jordan Fry" }, Producer = new Producer{Name="Dorothy McKim"}},
            new Movie {Title="Ratatouille",ReleaseDate=DateTime.Parse("2007-06-29"), Star = new Star{ Name="Patton Oswalt" }, Producer = new Producer{Name="Brad Lewis"}},
            new Movie {Title="WALL-E",ReleaseDate=DateTime.Parse("2008-06-27"), Star = new Star{ Name="Ben Burtt" }, Producer = new Producer{Name="Jim Morris"}},
            new Movie {Title="Roadside Romeo",ReleaseDate=DateTime.Parse("2008-10-24"), Star = new Star{ Name="Saif Ali Khan" }, Producer = new Producer{Name="Aditya Chopra"}},
            new Movie {Title="Bolt",ReleaseDate=DateTime.Parse("2008-11-21"), Star = new Star{ Name="John Travolta" }, Producer = new Producer{Name="Clark Spencer"}},
            new Movie {Title="Up",ReleaseDate=DateTime.Parse("2009-05-29"), Star = new Star{ Name="Ed Asner" }, Producer = new Producer{Name="Jonas Rivera"}},
            new Movie {Title="A Christmas Carol",ReleaseDate=DateTime.Parse("2009-11-06"), Star = new Star{ Name="Jim Carrey" }, Producer = new Producer{Name="Robert Zemeckis"}},
            new Movie {Title="The Princess and the Frog",ReleaseDate=DateTime.Parse("2009-12-11"), Star = new Star{ Name="Anika Noni Rose" }, Producer = new Producer{Name="John Lasseter"}},
            new Movie {Title="Toy Story 3",ReleaseDate=DateTime.Parse("2010-06-18"), Star = new Star{ Name="Tom Hanks" }, Producer = new Producer{Name="Darla K. Anderson"}},
            new Movie {Title="Tangled",ReleaseDate=DateTime.Parse("2010-11-24"), Star = new Star{ Name="Mandy Moore" }, Producer = new Producer{Name="Roy Conli"}},
            new Movie {Title="Mars Needs Moms",ReleaseDate=DateTime.Parse("2011-03-11"), Star = new Star{ Name="Seth Green" }, Producer = new Producer{Name="Steve Starkey"}},
            new Movie {Title="Cars 2",ReleaseDate=DateTime.Parse("2011-06-24"), Star = new Star{ Name="Larry the Cable Guy" }, Producer = new Producer{Name="Denise Ream"}},
            new Movie {Title="Winnie the Pooh",ReleaseDate=DateTime.Parse("2011-06-15"), Star = new Star{ Name="Jim Cummings" }, Producer = new Producer{Name="Peter Del Vecho"}},
            new Movie {Title="Arjun: The Warrior Prince",ReleaseDate=DateTime.Parse("2012-04-20"), Star = new Star{ Name="Yuddvir Bakolia" }, Producer = new Producer{Name="Ronnie Screwvala"}},
            new Movie {Title="Brave",ReleaseDate=DateTime.Parse("2012-06-22"), Star = new Star{ Name="Kelly Macdonald" }, Producer = new Producer{Name="Katherine Sarafian"}},
            new Movie {Title="Frankenweenie",ReleaseDate=DateTime.Parse("2012-10-05"), Star = new Star{ Name="Charlie Tahan" }, Producer = new Producer{Name="Tim Burton"}},
            new Movie {Title="Wreck-It Ralph",ReleaseDate=DateTime.Parse("2012-11-02"), Star = new Star{ Name="John C. Reilly" }, Producer = new Producer{Name="Clark Spencer"}},
            new Movie {Title="Monsters University",ReleaseDate=DateTime.Parse("2013-06-21"), Star = new Star{ Name="Billy Crystal" }, Producer = new Producer{Name="Kori Rae"}},
            new Movie {Title="Planes",ReleaseDate=DateTime.Parse("2013-08-09"), Star = new Star{ Name="Dane Cook" }, Producer = new Producer{Name="Tracy Balthazor-Flynn"}},
            new Movie {Title="Frozen",ReleaseDate=DateTime.Parse("2013-11-27"), Star = new Star{ Name="Kristen Bell" }, Producer = new Producer{Name="Peter Del Vecho"}},
            new Movie {Title="Planes: Fire & Rescue",ReleaseDate=DateTime.Parse("2014-07-18"), Star = new Star{ Name="Stacy Keach" }, Producer = new Producer{Name="Ferrell Barron"}},
            new Movie {Title="Big Hero 6",ReleaseDate=DateTime.Parse("2014-11-07"), Star = new Star{ Name="Ryan Potter" }, Producer = new Producer{Name="Kristina Reed"}},
            new Movie {Title="Inside Out",ReleaseDate=DateTime.Parse("2015-06-19"), Star = new Star{ Name="Amy Poehler" }, Producer = new Producer{Name="Jonas Rivera"}},
            new Movie {Title="The Good Dinosaur",ReleaseDate=DateTime.Parse("2015-11-25"), Star = new Star{ Name="Raymond Ochoa" }, Producer = new Producer{Name="Denise Ream"}},
            new Movie {Title="Zootopia",ReleaseDate=DateTime.Parse("2016-03-04"), Star = new Star{ Name="Ginnifer Goodwin" }, Producer = new Producer{Name="Clark Spencer"}},
            new Movie {Title="Finding Dory",ReleaseDate=DateTime.Parse("2016-06-17"), Star = new Star{ Name="Ellen DeGeneres" }, Producer = new Producer{Name="Lindsey Collins"}},
            new Movie {Title="Moana",ReleaseDate=DateTime.Parse("2016-11-23"), Star = new Star{ Name="Auliʻi Cravalho" }, Producer = new Producer{Name="Osnat Shurer"}},
            new Movie {Title="Cars 3",ReleaseDate=DateTime.Parse("2017-06-16"), Star = new Star{ Name="Owen Wilson" }, Producer = new Producer{Name="Kevin Reher"}},
            new Movie {Title="Coco",ReleaseDate=DateTime.Parse("2017-11-22"), Star = new Star{ Name="Anthony Gonzalez" }, Producer = new Producer{Name="Darla K. Anderson"}},
            new Movie {Title="Incredibles 2",ReleaseDate=DateTime.Parse("2018-06-15"), Star = new Star{ Name="Holly Hunter" }, Producer = new Producer{Name="John Walker"}},
            new Movie {Title="Christopher Robin",ReleaseDate=DateTime.Parse("2018-07-23"), Star = new Star{ Name="Ewan McGregor" }, Producer = new Producer{Name="Brigham Taylor"}},
            new Movie {Title="Ralph Breaks the Internet",ReleaseDate=DateTime.Parse("2018-07-23"), Star = new Star{ Name="Sarah Silverman" }, Producer = new Producer{Name="Clark Spencer"}},
            new Movie {Title="Toy Story 4",ReleaseDate=DateTime.Parse("2019-07-23"), Star = new Star{ Name="Tom Hanks" }, Producer = new Producer{Name="Jonas Rivera"}}
            };
            movies.ForEach(m => context.Movies.Add(m));

            context.Stars.Add(movies[0].Star);
            context.Producers.Add(movies[0].Producer);
            context.SaveChanges();
        }
    }
}