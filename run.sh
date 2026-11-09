#!/bin/bash
# Usage: ./run.sh <question number 1-30>   or   ./run.sh <file name>, e.g. ./run.sh q1fibo_prac
# Builds the chosen program (each file has its own Main, picked with StartupObject) and runs it.
cd "$(dirname "$0")/ExamPrograms" || exit 1
if [[ "$1" =~ ^[0-9]+$ ]]; then
  n=$(printf "%02d" "$1"); file=$(ls Q${n}_*.cs 2>/dev/null | head -1)
else
  file="$(basename "${1%.cs}").cs"; [ -f "$file" ] || file=""   # your own file, e.g. ./run.sh q1fibo_prac
fi
[ -z "$file" ] && { echo "No program for $1"; exit 1; }
out="bin/run/${file%.cs}"; mkdir -p bin/run
dotnet build -nologo -v q -p:StartupObject="${file%.cs}.Program" -p:IntermediateOutputPath="obj/q/${file%.cs}/" -o "$out" > "$out.buildlog" 2>&1 \
  || { cat "$out.buildlog"; exit 1; }
dotnet "$out/ExamPrograms.dll"
