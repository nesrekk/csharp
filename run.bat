@echo off
rem Build and run one exam program on Windows.
rem   run 7                  runs Q07_ReverseWords.cs
rem   run Q07_ReverseWords   same, by file name (also works for your own files)
setlocal EnableDelayedExpansion
cd /d "%~dp0ExamPrograms" || exit /b 1

if "%~1"=="" (
  echo Usage: run 7    or    run Q07_ReverseWords
  exit /b 1
)

set "file="
echo %~1| findstr /r "^[0-9][0-9]*$" >nul
if not errorlevel 1 (
  set "n=%~1"
  if !n! lss 10 set "n=0!n!"
  for %%f in (Q!n!_*.cs) do set "file=%%~nf"
) else (
  if exist "%~n1.cs" set "file=%~n1"
)

if "!file!"=="" (
  echo No program for %~1
  exit /b 1
)

set "out=bin\run\!file!"
dotnet build -nologo -v q "-p:StartupObject=!file!.Program" "-p:IntermediateOutputPath=obj\q\!file!\\" -o "!out!"
if errorlevel 1 exit /b 1
dotnet "!out!\ExamPrograms.dll"
