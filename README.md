# PSmono
powershell MonoTorrent method.

Generate a dll for powershell to call MonoTorrent method.

Install MonoTorrent to project: Install-Package MonoTorrent -Version 1.0.25, then build.

https://www.nuget.org/packages/MonoTorrent/

Example:

[string]$assemblyPath = 'monoTest\monoTest\bin\Debug\monoTest.dll'

Add-Type -Path $assemblyPath

$Torrent=New-Object PSmono.PSMonoOBJ

$Torrent.GetHash(torrentfile)

$Torrent.GetComment(torrentfile)

$Torrent.GetTorrentName(torrentfile)

$Torrent.GetTorrentSize(torrentfile) / 1GB

$Torrent.GetTorrentFiles(torrentfile)
