﻿echo off
title Korea Guest Reset
SetLocal EnableExtensions EnableDelayedExpansion
adb kill-server
adb start-server
goto RoutineX
:resume1
adb push %TEMP%\device_id.xml /data/data/com.pubg.krmobile/shared_prefs
adb push %TEMP%\device_id.xml /data/data/com.pubg.krmobile-1/shared_prefs
::Handle AndroidID here, Change
echo "Your Old Device ID :"
adb shell settings get secure android_id
set "IDD="
for /L %%i in (1,1,16) do call :Pseudo
adb shell settings put secure android_id %IDD%
adb shell content insert --uri content://settings/secure --bind name:s:android_id --bind value:s:%IDD%

adb shell setprop ro.mac_address %IDD%
adb shell setprop ro.product.device %IDD%
adb shell setprop ro.product.brand %IDD%
adb shell setprop ro.product.model %IDD%
adb shell setprop ro.product.name %IDD%
adb shell setprop ro.product.manufacturer %IDD%
adb shell setprop ro.android_id %IDD%
adb shell setprop net.hostname %IDD%
adb shell setprop gaid %IDD%
adb shell setprop android.device.id %IDD%
adb shell setprop ro.serialno %IDD%
adb shell setprop ro.runtime.firstboot %IDD%

echo "Your New Device ID :"
echo %IDD%
goto EmptyRecords
:resume2
echo Done
taskkill /IM "adb.exe" /T /F
timeout /t 3
goto :eof
:EmptyRecords
echo Cleaning ID related files please wait 2 minutes
adb kill-server > nul 2>&1
adb start-server > nul 2>&1
adb remount > nul 2>&1
adb shell rm -rf /sdcard/Android/.system_android_l2 > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile/cache/* > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile-1/cache/* > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile/code_cache/* > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile-1/code_cache/* > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile/shared_prefs/* > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile-1/shared_prefs/* > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile/databases/* > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile-1/databases/* > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /data/data/com.pubg.krmobile-1/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/cache/* > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile-1/cache/* > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile-1/files/.system_android_l2 > nul 2>&1
goto resume2

:Pseudo
set /a x=%random% %% 22 
set IDD=%IDD%!string:~%x%,1!
goto :eof

:RoutineX
set "string=abcdefABCDEF0123456789"
set "rr="
for /L %%i in (1,1,4) do call :Pseudorr
set "ss="
for /L %%i in (1,1,4) do call :Pseudoss
set "tt="
for /L %%i in (1,1,4) do call :Pseudott
set "uu="
for /L %%i in (1,1,4) do call :Pseudouu
set "vv="
for /L %%i in (1,1,4) do call :Pseudovv
set "ww="
for /L %%i in (1,1,4) do call :Pseudoww
set "xx="
for /L %%i in (1,1,4) do call :Pseudoxx
set "yy="
for /L %%i in (1,1,4) do call :Pseudoyy
DEL %TEMP%\device_id.xml
echo %h1%>>%TEMP%\device_id.xml
echo %h2%>>%TEMP%\device_id.xml
echo %h3%>>%TEMP%\device_id.xml
echo %h4%>>%TEMP%\device_id.xml
echo %h5%>>%TEMP%\device_id.xml
echo %h6%>>%TEMP%\device_id.xml
goto resume1

:resume1
adb shell am start -n com.pubg.krmobile/com.epicgames.ue4.SplashActivity
goto :eof