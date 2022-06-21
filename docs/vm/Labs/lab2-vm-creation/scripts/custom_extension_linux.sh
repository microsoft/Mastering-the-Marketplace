#!/bin/sh

sudo apt-get update

sudo apt-get upgrade -y 

sudo apt-get install apache2 -y

sudo sed -i '224s|\(.*\)|Welcome to your Server for the Virtual Machine Offers Workshop!\1|' /var/www/html/index.html

sudo service apache2 restart
