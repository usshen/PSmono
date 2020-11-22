# PSmono
powershell MonoTorrent method.

Generate a dll for powershell to call MonoTorrent method.

Install MonoTorrent to project: Install-Package MonoTorrent -Version 1.0.25

https://www.nuget.org/packages/MonoTorrent/

[string]$assemblyPath = 'monoTest\monoTest\bin\Debug\monoTest.dll'

Add-Type -Path $assemblyPath

$Torrent=New-Object PSmono.PSMonoOBJ

$Torrent.hashinfomation('torrentfile.torrent')
