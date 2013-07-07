@echo off

Testing

@if "%ERRORLEVEL%" == "0" goto success

:fail
echo App has failed!
echo ExitCode = %ERRORLEVEL%.
goto end

:success
echo App has succeeded!
echo ExitCode = %ERRORLEVEL%.
goto end

:end
echo All Done.
