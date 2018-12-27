using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsCollectionViewSample
{
    public partial class MainPage : ContentPage
    {
        public List<Actor> Actors = new List<Actor>
        {
            new Actor
            {
                Name = "Michael Luwoye",
                Plays = "Alexander Hamilton",
                Picture = "hamilton.jpg"
            },
            new Actor
            {
                Name = "Daniel Breaker",
                Plays = "Aaron Burr",
                Picture = "burr.jpg"
            },
            new Actor
            {
                Name = "Mandy Gonzalez",
                Plays = "Angelica Schuyler",
                Picture = "schuyler.jpg"
            },
            new Actor
            {
                Name = "Denée Benton",
                Plays = "Eliza",
                Picture = "eliza.jpg"
            },
            new Actor
            {
                 Name = "Euan Morton",
                 Plays = "King George",
                 Picture = "george.jpg"
            },
            new Actor
            {
                 Name = "James Monroe Iglehart",
                 Plays = "Thomas Jefferson",
                 Picture = "jefferson.jpg"
            },
            new Actor
            {
                  Name = "Carvens Lissaint",
                  Plays = "George Washington",
                  Picture = "washington.jpg"
            },
            new Actor
            {
                  Name = "Anthony Lee Medina",
                  Plays = "Phillip Hamilton",
                  Picture = "phamilton.jpg"
            },
            new Actor
            {
                  Name = "Alysha Deslorieux",
                  Plays = "Maria Reynolds",
                  Picture = "reynolds.jpg"
            },
            new Actor
            {
                  Name = "J. Quinton Johnson",
                  Plays = "James Madison",
                  Picture = "madison.jpg"
            }
        };

        public MainPage()
        {
            BindingContext = Actors;
            InitializeComponent();
        }
    }
}
