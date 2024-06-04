# AWS-Beginner

[AWS - Essential](https://explore.skillbuilder.aws/learn/course/internal/view/elearning/1564/aws-cloud-practitioner-essentials-german-na)


## Cloud Computing

    -   im Skill Builder kann man Übungen starten
    -   AWS - Cloud Server steht in Frankfurt
    -   AWS - Cloud ist skalierbar (vertikale skalierung)


## EC2

    -   Ist eine virtuelle Maschine in AWS
    -   Amazon Elastic Cloud 2 

## secruity Group

    -   Firewall ( Port config)


## Load Balancer

    -   verteilt anfragen auf den WebServer


## Auto-Scalling-Group
    -   bevor der WebServer in die Knie geht würde AWS eine neue Instanz aufsetzen repliziert 
    -   würde dann zusätzliche Kosten anwerfen
    - kann auch expliziet in anderen Regions zurückgreifen (baut automatisch in eine andere Availibity Zone)

## Frankfurt

    -   eine Region mit 3 Avaibility Zones (physisch getrennt)
    -   rendundant gewährleistet
    -   

## S3

    -   ist ein Online Speicher mächtiger als DropBox
    -   kann auch html online verfügbar machen

## install

![Config](./screens/KW20/AWS%20I-invert.png)


## DNS - Service 

## Route 53

    -   mit r53 kann man seine eigene Domaine in die Cloud ziehen
    -   Domain hosting möglich

## SDKs

    -   erstellen automatisiert AWS Resourcen
    -   deployment Kits (bitte baue mir das , das , das )


## snow-cone
    -   einzelne Festplatten an AWS schicken
    -   oder USB-Stick

## snow-ball
    -   AWS schick einem Server man spielt die Daten drauf und schickt diese zurück

## snow-mobil
    -   LKW dieser wird bereitgestellt um alle Daten in den Truck zu laden um cloud anbieter an AWS zu binden


## Speicher

    -   EBS liegt in einer Einer Avability Zone

## Bucket

    -   kann eine WebSite hosten

## RDS Amazon Relation Database

# Linux



DB-Instance-Kennung	(so heißt die Machine):

	db-dannys-aws-machine



HauptbenutzernameInformationen
Geben Sie eine Anmelde-ID für den Hauptbenutzer Ihrer DB-Instance ein.:

	root


Hauptpasswort:

	Pa$$w0rd

Datenbankoptionen
Anfänglicher Datenbankname:

	dannysWordpress


Endpunkt und Port:

	db-dannys-aws-machine.ctfu1ip0w6hu.eu-central-1.rds.amazonaws.com





i-083725d85cd5f5601 (dannys-EC2-for-Wordpress)
Öffentliche IPv4-Adresse:

	3.72.63.59


## Terminal Befehle Linux Arch :

	
	sudo  yum install mysql -y


### Zuweisung der Datenbank zur Machine

	export MYSQL_HOST=db-dannys-aws-machine.ctfu1ip0w6hu.eu-central-1.rds.amazonaws.com.

### DB Anmeldung mit dem User root

	mysql -u root -p dannysWordpress


### DB Benutzer 2 anlegen

	create user 'adwin' identified by 'password' ;

### BN: Adwin bekommt alle Rechte an der Datenbank

	grant all privileges on wordpress.* to 'adwin';

#### httpd Service & starten

	sudo yum install httpd -y
.

	sudo service httpd start

#### wordpress runter laden

	wget https://Wordpress.org/latest.tar.gz

#### wordpress entpacken

	tar -xzf latest.tar.gz

#### Ordner struktur 

	cd wordpress
.

	ls
.

	cp wp-config-sample.php wp-config.php
.

	ls
.

	sudo nano wp-config.php
.
	
	
#### wordpress wp-config anpassen

.
````ps
	define ('DB_NAME' , 	'dannysWordpress'	);
	define ('DB_USER' , 	'root'				);
	define ('DB_PASSWORD' , 'Pa$$w0rd'			);
	define ('DB_HOST' , 	'db-dannys-aws-machine-ctfulip0w6hu.eu-central-1.rds.amazonaws.com');
	define ('DB_CHARSET',	'utf8'				);
	define ('DB_COLLATE',	''					);
````
.


````ps
define('AUTH_KEY',         '@5H0Q8tBp*uIV%CK)`W0yflB`0Xlf|<]G/:O,H=;NOfq;XQI<_+}?`z*jq+[PuTv');
define('SECURE_AUTH_KEY',  'r4eC{`wFA/gk0U*w6(C++&R8d,`1}r&@=J3+C8SYw`KZC/#_&7D|aHH-tr;WO/2^');
define('LOGGED_IN_KEY',    'QBQUQ ?Ut!yJqmCCx-iPUL>6F&j^uVN+4$)/d5A`TA`=$|XX>-GkTSY.3sa)0bw(');
define('NONCE_KEY',        'c(:dl>iN%_;.b-+/|+vBury2(-t]u8@ySwJaero{d)9}rIs=llMTiG6]#.vw}ahq');
define('AUTH_SALT',        'Of`rOa,/[Ay4+}#!5!q:+I-J|TTW`v -,MM/;mmv0l#4Sc6Ka|jd+X9D6c9Qs=|=');
define('SECURE_AUTH_SALT', 'LI[B*3B+oT=FyE?dU!e|rJb-9e..>rJ4h`DN}Sm3</r89oa]KH= SHo|JZS;qozF');
define('LOGGED_IN_SALT',   ')WJ0}WRA(;-]D<C)G%)W~@>v2Y?NVNT9d4|T<;Inms1|woa[s.y:O4b <-n,QiIN');
define('NONCE_SALT',       '6{b`NYlyE%9WWjo8/.K25>}2>]>x0JJ5xt3KWTW~X~YL.Y;FuDL+(W8-;c 4+@3#');
````


#### extras installieren

	sudo amazon-linux-extras install -y lamp-mariadb10.2-php7.2 php7.2

.

	cd
.
#### wordpress mit Inhalt in WebServer Standard-Pfad kopiert
	sudo cp -r wordpress/* /var/www/html/
.

	sudo service httpd restart
.	
#### in auto start einfügen

	sudo chkconfig httpd on 

#### ordner vom WebServer anzeigen lasse

	cd /var/www/html
.

	ls
.
#### Inhalte anzeigen lassen (alternative zu >> tree /f <<)

	ls -R -l

#### console clear

	STRG + L




. 


### Sicherheitrolle anpassen

	PORT:	21				Anywhere		Zugang
	PORT:	1024 - 1048		Anywhere	FTP-Zugang

### Fileserver installieren
	sudo yum install vsftpd -y

### FileServer Config anpassen
	sudo nano /etc/vsftpd/vsftpd.conf

### unter der vsftpd.conf ändern

	#chroot_local_user=YES

.

	chroot_local_user=YES
	allow_writeable_chroot=YES

.
### ganz unten ein paar Zeilen in die vsftpd.conf einfügen

	pam_service_name=vsftpd
	userlist_enable=NO
	tcp_wrappers=YES
	pasv_min_port=1024
	pasv_max_port=1048
	pasv_address=3.68.150.21
	

.
### neuen Benutzer anlegen

	sudo adduser danny
	sudo passwd admin
	sudo usermod -d /var/www/html/ danny

	cd /var/www/html/
	sudo usermod -a -G root danny
	sudo service vsftpd restart


### Filezilla auf dem HOST installieren

	https://www.heise.de/download/product/filezilla-18785/download/danke?id=6e520316-e188-4944-9531-92147782457c
.

.

### nodejs installieren


##

    sudo yum install nodejs -y

.

    sudo mdir -p/var/app/

.

    cd /var/app
.

    cd ..

.

    sudo wget https://aws-tc-largeobjects.s3-us-west-2.amazonaws.com/ILT-TF-100-TECESS-5/app/app.zip
.

    sudo unzip app.zip -d /var/app/
.
    
    cd  /var/app/
    sudo npm install -y
.

    cd ..
.

    cd var/app/api/common/

.

    sudo nano constants.js




.

.

.

.

.

.

## Terminal Befehle Linux Ubuntu :

	sudo apt-get install mysql-server -y

### Benutzer anlegen

	mysql -u root -p
.

	CREATE USER 'adwin'@'localhost' IDENTIFIED BY 'password';
.

	GRANT ALL PRIVILEGES ON databasename.* TO'adwin'@'localhost';
.

	FLUSH PRIVILEGES;

### Apache installieren

	sudo apt-get update
.

	sudo apt-get install apache2 -y

### Dienst Starten

	sudo systemctl start apache2
.

### wordpress install

	wget https://Wordpress.org/latest.tar.gz
.

	tar -xzf latest.tar.gz
.

	cd wordpress
.

	ls


### config DAtei anpassen

	cp wp-config-sample.php wp-config.php
.

	ls
.

	sudo nano wp-config.php

.

	cp wp-config-sample.php wp-config.php

.
````ps
	define ('DB_NAME' , 	'dannysWordpress'	);
	define ('DB_USER' , 	'root'				);
	define ('DB_PASSWORD' , 'Pa$$w0rd'			);
	define ('DB_HOST' , 	'db-dannys-aws-machine-ctfulip0w6hu.eu-central-1.rds.amazonaws.com');
	define ('DB_CHARSET',	'utf8'				);
	define ('DB_COLLATE',	''					);
````

.

```ps
define('AUTH_KEY',         '@5H0Q8tBp*uIV%CK)`W0yflB`0Xlf|<]G/:O,H=;NOfq;XQI<_+}?`z*jq+[PuTv');
define('SECURE_AUTH_KEY',  'r4eC{`wFA/gk0U*w6(C++&R8d,`1}r&@=J3+C8SYw`KZC/#_&7D|aHH-tr;WO/2^');
define('LOGGED_IN_KEY',    'QBQUQ ?Ut!yJqmCCx-iPUL>6F&j^uVN+4$)/d5A`TA`=$|XX>-GkTSY.3sa)0bw(');
define('NONCE_KEY',        'c(:dl>iN%_;.b-+/|+vBury2(-t]u8@ySwJaero{d)9}rIs=llMTiG6]#.vw}ahq');
define('AUTH_SALT',        'Of`rOa,/[Ay4+}#!5!q:+I-J|TTW`v -,MM/;mmv0l#4Sc6Ka|jd+X9D6c9Qs=|=');
define('SECURE_AUTH_SALT', 'LI[B*3B+oT=FyE?dU!e|rJb-9e..>rJ4h`DN}Sm3</r89oa]KH= SHo|JZS;qozF');
define('LOGGED_IN_SALT',   ')WJ0}WRA(;-]D<C)G%)W~@>v2Y?NVNT9d4|T<;Inms1|woa[s.y:O4b <-n,QiIN');
define('NONCE_SALT',       '6{b`NYlyE%9WWjo8/.K25>}2>]>x0JJ5xt3KWTW~X~YL.Y;FuDL+(W8-;c 4+@3#');

```
.

### extras installieren

	sudo apt-get install apache2 mariadb-server php php7.2 php7.2-{cli,mysql,xml}

.

	sudo systemctl start apache2

.
	
	sudo systemctl enable apache2

.

	sudo mysql_secure_installation
.

	CREATE USER 'adwin'@'localhost' IDENTIFIED BY 'password';
.

	sudo mysql -u root -p
.

	sudo cp -r ~/wordpress/* /var/www/html/
.

	sudo nano /etc/apache2/sites-available/000-default.conf
.

	DocumentRoot /var/www/html
.
	
	sudo systemctl restart apache2
.

	SELECT User, Host FROM mysql.user;

.
###	wp-config kontrollieren

[Wordpress](https://api.wordpress.org/secret-key/1.1/salt/)



## Html auf einer Instance freischalten erstellen
	
	sudo touch index.html

### nano

	sudo nano index.html

.

	<html><boby><h1>Ich bin eine Überschrift in der 172.21.22.39</h1></body></html>

.

	sudo service httpd start

.

	sudo chkconfig httpd on


