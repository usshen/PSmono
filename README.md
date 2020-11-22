# PSmono
powershell MonoTorrent method.

Generate a dll for powershell to call MonoTorrent method.

[string]$assemblyPath = 'monoTest\monoTest\bin\Debug\monoTest.dll'

Add-Type -Path $assemblyPath

$Torrent=New-Object PSmono.PSMonoOBJ

$Torrent.hashinfomation('torrent.torrent')
