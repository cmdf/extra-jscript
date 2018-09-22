Run a Jscript.NET script in Windows Console.
> 1. Download [exe file](https://raw.githubusercontent.com/winp/extra-bel/master/ecd.cmd).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> ejscript [-c|--compile] [-o|--output <output binary>] <input script> [input arguments to script]...

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: run "pokemon.js" with no input arguments
> ejscript pokemon.js

:: run "pokemon.js" with input argument "bulbasaur"
> ejscript pokemon.js bulbasaur

:: run "pokemon.js" with input arguments "bulbasaur --height"
> ejscript pokemon.js bulbasaur --height

:: only compile "pokemon.js", and get its output path
> ejscript --compile pokemon.js

:: set output binary for "pokemon.js" and run
> ejscript --output "C:\Games and Apps\pokemon.exe" pokemon.js

:: set output binary for "pokemon.js" and only compile
> ejscript --output "C:\Games and Apps\pokemon.exe" --compile pokemon.js

:: run "ocolor.cmd" with input arguments "yellow black"
> ejscript ocolor.cmd yellow black
```
