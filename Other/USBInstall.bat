@echo off
rem Basic setup stuff
title OSB Installer
set installloc=%CD%
set kernelname=kernel.txt
set bootname=boot.txt
set font=font.txt
rem GIVE US INFO USER
echo Before you start, make sure the target drive is formatted.
pause >nul
set /p drivepath=Enter the drive you want to install OSB on:
rem Do the copying and dir making needed (MAY REQUIRE CHANGES)
cd %drivepath%
mkdir efi
cd efi
mkdir boot
cd boot
copy "%installloc%\%bootname%" ./boot >nul
cd ../
cd ../
copy "%installloc%\%kernelname%" ./boot >nul
copy "%installloc%\%font%" ./boot >nul
rem Only if we will use "Userspace"!
mkdir userspace
echo OSB is installed! Press any key to close this wizard.
pause >nul
