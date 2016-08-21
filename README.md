# ojscript

Run a Jscript.NET script in Windows Console.


## usage

```batch
> ojscript [-c|--compile] [-o|--output <output binary>] <input script> [input arguments to script]...

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: run "pokemon.js" with no input arguments
> ojscript pokemon.js

:: run "pokemon.js" with input argument "bulbasaur"
> ojscript pokemon.js bulbasaur

:: run "pokemon.js" with input arguments "bulbasaur --height"
> ojscript pokemon.js bulbasaur --height

:: only compile "pokemon.js", and get its output path
> ojscript --compile pokemon.js

:: set output binary for "pokemon.js" and run
> ojscript --output "C:\Games and Apps\pokemon.exe" pokemon.js

:: set output binary for "pokemon.js" and only compile
> ojscript --output "C:\Games and Apps\pokemon.exe" --compile pokemon.js

:: run "ocolor.cmd" with input arguments "yellow black"
> ojscript ocolor.cmd yellow black
```
