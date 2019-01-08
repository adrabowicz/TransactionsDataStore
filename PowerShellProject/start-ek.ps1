Set-Location -Path C:\elasticsearch-6.4.1-node-0\bin
start-process "cmd.exe" -ArgumentList '/c elasticsearch.bat'

Set-Location -Path C:\kibana-6.4.1-windows-x86_64\bin
start-process "cmd.exe" -ArgumentList '/c kibana.bat'
