﻿using Entities;

var song1 = new Song("Habit", "Sekai no Owari",  2022);
var song2 = new Song("My Jolly Sailor Bold", "Ashley Serena", 2020);
var song3 = new Song("Killing Me Softly", "Fugees", 1996);
var song4 = new Song("Tiny Dancer", "Elton John",1971);
var song5 = new Song("Ancient Dreams in a Modern Land", "MARINA", 2021);

var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);

Console.WriteLine("Before shuffle");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();


Console.WriteLine("\n\n After shuffle");
Console.WriteLine(playlist1.GetSongs());

NotepadServices notepadServices = new();
notepadServices.PlaylistToNotepad(playlist1);

