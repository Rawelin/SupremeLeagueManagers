
function songShuffle(player, path, quantity) {

    var songs = []

    for (var i = 1; i < quantity; i++) {
        songs.push(path + i + ".mp3")
    }

    for (let i = songs.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * i)
        const temp = songs[i]
        songs[i] = songs[j]
        songs[j] = temp
    }
    musicPlayer(player, songs);
}

function musicPlayer(music_player, songs) {

    var i = 0;

    function next() {
        // Check for last audio file in the playlist
        if (i === songs.length - 1) {
            i = 0;
        } else {
            i++;
        }

        // Change the audio element source
        music_player.src = songs[i];
    }

    if (music_player === null) {
        throw "Playlist Player does not exists ...";
    } else {
        // Start the player
        music_player.src = songs[i];

        // Listen for the music ended event, to play the next audio file
        music_player.addEventListener('ended', next, false)
    }
}