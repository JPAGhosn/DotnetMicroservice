#!/usr/bin/env bash

FOLDER_NAME=$1; # Ex: ./base-ef.sh Collections

cd ../.. || exit;

rm -r ${FOLDER_NAME}/Migrations;

/usr/local/share/dotnet/dotnet ef database \
  drop --project ${FOLDER_NAME}/${FOLDER_NAME}.csproj \
  --startup-project ${FOLDER_NAME}/${FOLDER_NAME}.csproj \
  --context ${FOLDER_NAME}.Data.${FOLDER_NAME}DbContext \
  --configuration Debug --force;
  
/usr/local/share/dotnet/dotnet ef migrations \
  add --project ${FOLDER_NAME}/${FOLDER_NAME}.csproj \
  --startup-project ${FOLDER_NAME}/${FOLDER_NAME}.csproj \
  --context ${FOLDER_NAME}.Data.${FOLDER_NAME}DbContext \
  --configuration Debug Initial \
  --output-dir Migrations;
  
/usr/local/share/dotnet/dotnet ef database update \
  --project ${FOLDER_NAME}/${FOLDER_NAME}.csproj \
  --startup-project ${FOLDER_NAME}/${FOLDER_NAME}.csproj \
  --context ${FOLDER_NAME}.Data.${FOLDER_NAME}DbContext;