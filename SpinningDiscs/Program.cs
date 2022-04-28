using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> songs = new List<string>
            {
                "Agoraphobia", "Here in My Room", "Southern Girl"
            };
            // TODO: Declare and initialize a CD and a DVD object.
            CD album = new CD("A Crow Left Of The Murder", 100, songs, 14);
            DVD movie = new DVD("Shrek 2", 10, songs, 1.5);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            album.DisplayInfo();
            album.Play();
            album.SpinDisc();
            
            movie.DisplayInfo();
            movie.Play();
            movie.SpinDisc();
        }
    }
}
