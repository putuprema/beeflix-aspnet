using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BeeFlix.Models;

namespace BeeFlix.Data
{
    public static class DataSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var context = new BeeFlixContext(
                serviceProvider.GetRequiredService<DbContextOptions<BeeFlixContext>>()))
            {
                if (context.Genre.Any()) { return; }

                context.Genre.AddRange(
                    new Genre
                    {
                        Name = "Drama",
                        Movies = new List<Movie>()
                        {
                            new Movie
                            {
                                Title = "The Shinning",
                                Description = "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/the-shining.jpg"
                            },

                            new Movie
                            {
                                Title = "Parasite",
                                Description = "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/parasite.jpg"
                            },

                            new Movie
                            {
                                Title = "Mulan",
                                Description = "A young Chinese maiden disguises herself as a male warrior in order to save her father.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/mulan.jpg"
                            },

                            new Movie
                            {
                                Title = "Joker",
                                Description = "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/joker.jpg"
                            },

                            new Movie
                            {
                                Title = "Interstellar",
                                Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/interstellar.jpg"
                            },

                            new Movie
                            {
                                Title = "Whiplash",
                                Description = "A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student's potential.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/whiplash.jpg"
                            },
                        }
                    },

                    new Genre
                    {
                        Name = "Kids",
                        Movies = new List<Movie>()
                        {
                            new Movie
                            {
                                Title = "Hotel Transylvania",
                                Description = "Dracula, who operates a high-end resort away from the human world, goes into overprotective mode when a boy discovers the resort and falls for the count's teenaged daughter.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/hotel-transylvania.jpg"
                            },

                            new Movie
                            {
                                Title = "Home Alone",
                                Description = "An eight-year-old troublemaker must protect his house from a pair of burglars when he is accidentally left home alone by his family during Christmas vacation.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/home-alone.jpg"
                            },

                            new Movie
                            {
                                Title = "Monsters, Inc.",
                                Description = "In order to power the city, monsters have to scare children so that they scream. However, the children are toxic to the monsters, and after a child gets through, 2 monsters realize things may not be what they think.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/monster-inc.jpg"
                            },

                            new Movie
                            {
                                Title = "Despicable Me",
                                Description = "When a criminal mastermind uses a trio of orphan girls as pawns for a grand scheme, he finds their love is profoundly changing him for the better.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/despicable-me.jpg"
                            },

                            new Movie
                            {
                                Title = "Toy Story",
                                Description = "A cowboy doll is profoundly threatened and jealous when a new spaceman figure supplants him as top toy in a boy's room.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/toy-story.jpg"
                            },

                            new Movie
                            {
                                Title = "Ratatouille",
                                Description = "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous restaurant.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/ratatouille.jpg"
                            },
                        }
                    },

                    new Genre
                    {
                        Name = "TV Shows",
                        Movies = new List<Movie>()
                        {
                            new Movie
                            {
                                Title = "Game of Thrones",
                                Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/game-of-thrones.jpg",
                                Episodes = new List<Episode>()
                                {
                                    new Episode
                                    {
                                        Order = 1,
                                        Title = "Winterfell"
                                    },
                                    new Episode
                                    {
                                        Order = 2,
                                        Title = "A Knight of the Seven Kingdoms"
                                    },
                                    new Episode
                                    {
                                        Order = 3,
                                        Title = "The Long Night"
                                    },
                                    new Episode
                                    {
                                        Order = 4,
                                        Title = "The Last of the Starks"
                                    },
                                    new Episode
                                    {
                                        Order = 5,
                                        Title = "The Bells"
                                    },
                                    new Episode
                                    {
                                        Order = 6,
                                        Title = "The Iron Throne"
                                    },
                                }
                            },

                            new Movie
                            {
                                Title = "Rick and Morty",
                                Description = "An animated series that follows the exploits of a super scientist and his not-so-bright grandson.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/rick-and-morty.jpg",
                                Episodes = new List<Episode>()
                                {
                                    new Episode
                                    {
                                        Order = 1,
                                        Title = "Edge of Tomorty: Rick Die Rickpeat"
                                    },

                                    new Episode
                                    {
                                        Order = 2,
                                        Title = "The Old Man and the Seat"
                                    },

                                    new Episode
                                    {
                                        Order = 3,
                                        Title = "One Crew Over the Crewcoo's Morty"
                                    },

                                    new Episode
                                    {
                                        Order = 4,
                                        Title = "Claw and Hoarder: Special Ricktim's Morty"
                                    },

                                    new Episode
                                    {
                                        Order = 5,
                                        Title = "Rattlestar Ricklactica"
                                    },

                                    new Episode
                                    {
                                        Order = 6,
                                        Title = "Never Ricking Morty"
                                    },
                                    new Episode
                                    {
                                        Order = 7,
                                        Title = "Promortyus"
                                    },
                                    new Episode
                                    {
                                        Order = 8,
                                        Title = "The Vat of Acid Episode"
                                    },
                                    new Episode
                                    {
                                        Order = 9,
                                        Title = "Childrick of Mort"
                                    },
                                    new Episode
                                    {
                                        Order = 10,
                                        Title = "Star Mort: Rickturn of the Jerri"
                                    },
                                }
                            },

                            new Movie
                            {
                                Title = "The Office",
                                Description = "The story of an office that faces closure when the company decides to downsize its branches. A documentary film crew follow staff and the manager David Brent as they continue their daily lives.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/the-office.jpg",
                                Episodes = new List<Episode>()
                                {
                                    new Episode
                                    {
                                        Order = 1,
                                        Title = "New Guys"
                                    },
                                    new Episode
                                    {
                                        Order = 2,
                                        Title = "Roy's Wedding"
                                    },
                                    new Episode
                                    {
                                        Order = 3,
                                        Title = "Andy's Ancestry"
                                    },
                                    new Episode
                                    {
                                        Order = 4,
                                        Title = "Work Bus"
                                    },
                                    new Episode
                                    {
                                        Order = 5,
                                        Title = "Here Comes Treble"
                                    },
                                    new Episode
                                    {
                                        Order = 6,
                                        Title = "The Boat"
                                    },
                                }
                            },

                            new Movie
                            {
                                Title = "Stranger Things",
                                Description = "When a young boy disappears, his mother, a police chief and his friends must confront terrifying supernatural forces in order to get him back.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/stranger-things.jpg",
                                Episodes = new List<Episode>()
                                {
                                    new Episode
                                    {
                                        Order = 1,
                                        Title = "Chapter One: Suzie, Do You Copy?"
                                    },
                                    new Episode
                                    {
                                        Order = 2,
                                        Title = "Chapter Two: The Mall Rats"
                                    },
                                    new Episode
                                    {
                                        Order = 3,
                                        Title = "Chapter Three: The Case of the Missing Lifeguard"
                                    },
                                    new Episode
                                    {
                                        Order = 4,
                                        Title = "Chapter Four: The Sauna Test"
                                    },
                                    new Episode
                                    {
                                        Order = 5,
                                        Title = "Chapter Five: The Flayed"
                                    },
                                    new Episode
                                    {
                                        Order = 6,
                                        Title = "Chapter Six: E Pluribus Unum"
                                    },
                                }
                            },

                            new Movie
                            {
                                Title = "The Simpsons",
                                Description = "The satiric adventures of a working-class family in the misfit city of Springfield.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/the-simpsons.jpg",
                                Episodes = new List<Episode>()
                                {
                                    new Episode
                                    {
                                        Order = 1,
                                        Title = "Bart's Not Dead"
                                    },
                                    new Episode
                                    {
                                        Order = 2,
                                        Title = "Heartbreak Hotel"
                                    },
                                    new Episode
                                    {
                                        Order = 3,
                                        Title = "My Way or the Highway to Heaven"
                                    },
                                    new Episode
                                    {
                                        Order = 4,
                                        Title = "Treehouse of Horror XXIX"
                                    },
                                    new Episode
                                    {
                                        Order = 5,
                                        Title = "Baby You Can't Drive My Car"
                                    },
                                    new Episode
                                    {
                                        Order = 6,
                                        Title = "From Russia Without Love"
                                    },
                                }
                            },

                            new Movie
                            {
                                Title = "House of Cards",
                                Description = "A Congressman works with his equally conniving wife to exact revenge on the people who betrayed him.",
                                Rating = 4,
                                Photo = "/Storage/MoviePosters/house-of-cards.jpg",
                                Episodes = new List<Episode>()
                                {
                                    new Episode
                                    {
                                        Order = 1,
                                        Title = "Chapter 1"
                                    },
                                    new Episode
                                    {
                                        Order = 2,
                                        Title = "Chapter 2"
                                    },
                                    new Episode
                                    {
                                        Order = 3,
                                        Title = "Chapter 3"
                                    },
                                    new Episode
                                    {
                                        Order = 4,
                                        Title = "Chapter 4"
                                    },
                                    new Episode
                                    {
                                        Order = 5,
                                        Title = "Chapter 5"
                                    },
                                    new Episode
                                    {
                                        Order = 6,
                                        Title = "Chapter 6"
                                    },
                                }
                            },
                        }
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
