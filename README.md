# AWS-Beginner

[AWS - Essential](https://explore.skillbuilder.aws/learn/course/internal/view/elearning/1564/aws-cloud-practitioner-essentials-german-na)

## Was ist Was ?!

-	[Cloud Computing](./AWS/docs/CloudComputing.md)
-	[EC2](./AWS/docs/ec2.md)
-	[secruity Group](./AWS/docs/SecruityGroup.md)
-	[Load Balancer](./AWS/docs/LoadBalancer.md)
-	[Auto-Scalling-Group](./AWS/docs/AutoScallingGroup.md)
-	[Frankfurt](./AWS/docs/Frankfurt.md)
-	[DNS](./AWS/docs/dns.md)
-	[ Route 53](./AWS/docs/Route53.md)
-	[SDKs](./AWS/docs/SDKs.md)
-	[s3](./AWS/docs/s3Bucket.md)
-	[CertificateÜbersicht](./AWS/docs/CertificateÜbersicht.md)
-	[Snow](./AWS/docs/Instance.md)
-	[EBS-Volumen](./AWS/docs/EBS-Volumen.md)
-	[HTML-s3Bucket](./AWS/docs/HTML-s3Bucket.md)
-	[HTML-WIN](./AWS/docs/HTML-WIN.md)
-	[IAM-Richtlinie](./AWS/docs/IAM-Richtlinie.md)
-	[Instance](./AWS/docs/Instance.md)
-	[MFA-Multifactor-Authentifizierung](./AWS/docs/MFA-Multifactor-Authentifizierung.md)
-	[VPC-erstellen](./AWS/docs/VPC-erstellen.md)
-	[WebServer-WIN](./AWS/docs/WebServer-WIN.md)
-	[WordpressUnterLinux](./AWS/docs/WordpressUnterLinux.md)
-	[EmployeerManagementTabel](./AWS/docs/EmployeerManagementTabel.md)









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
````ps

	db-dannys-aws-machine.ctfu1ip0w6hu.eu-central-1.rds.amazonaws.com
````





i-083725d85cd5f5601 (dannys-EC2-for-Wordpress)
Öffentliche IPv4-Adresse:
````ps

	3.72.63.59
````


## Terminal Befehle Arch-Linux:

````ps

	sudo  yum install mysql -y
````


### Zuweisung der Datenbank zur Machine
````ps

	export MYSQL_HOST=db-dannys-aws-machine.ctfu1ip0w6hu.eu-central-1.rds.amazonaws.com.
````

### DB Anmeldung mit dem User root
````ps

	mysql -u root -p dannysWordpress
````


### DB Benutzer 2 anlegen
````bash

	create user 'adwin' identified by 'password' ;
````

### BN: Adwin bekommt alle Rechte an der Datenbank
````bash

	grant all privileges on wordpress.* to 'adwin';
````

#### httpd Service & starten
````ps

	sudo yum install httpd -y
````
.
````ps

	sudo service httpd start
````

#### wordpress runter laden
````ps

	wget https://Wordpress.org/latest.tar.gz
````

#### wordpress entpacken
````ps

	tar -xzf latest.tar.gz
````

#### Ordner struktur 
````ps

	cd wordpress
````
.
````ps

	ls
````
.
````ps

	cp wp-config-sample.php wp-config.php
````
.
````ps

	ls
````
.
````ps

	sudo nano wp-config.php
````
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
````ps

	sudo amazon-linux-extras install -y lamp-mariadb10.2-php7.2 php7.2
````

.
````ps

	cd
````
.
#### wordpress mit Inhalt in WebServer Standard-Pfad kopiert
````ps

	sudo cp -r wordpress/* /var/www/html/
````
.
````ps

	sudo service httpd restart
````
.	
#### in auto start einfügen
````ps

	sudo chkconfig httpd on 
````

#### ordner vom WebServer anzeigen lasse
````ps

	cd /var/www/html
````
.
````ps

	ls
````
.
#### Inhalte anzeigen lassen (alternative zu >> tree /f <<)
````ps

	ls -R -l
````

#### console clear

	STRG + L




. 


### Sicherheitrolle anpassen

	PORT:	21				Anywhere		Zugang
	PORT:	1024 - 1048		Anywhere	FTP-Zugang

### Fileserver installieren
````ps

	sudo yum install vsftpd -y
````

### FileServer Config anpassen
````ps

	sudo nano /etc/vsftpd/vsftpd.conf
````

### unter der vsftpd.conf ändern

````conf

	#chroot_local_user=YES
````

.
````ps

	chroot_local_user=YES
	allow_writeable_chroot=YES
````

.

### ganz unten ein paar Zeilen in die vsftpd.conf einfügen
````ps

	pam_service_name=vsftpd
	userlist_enable=NO
	tcp_wrappers=YES
	pasv_min_port=1024
	pasv_max_port=1048
	pasv_address=3.68.150.21
````
	

.
### neuen Benutzer anlegen
````ps

	sudo adduser danny
	sudo passwd admin
	sudo usermod -d /var/www/html/ danny

	cd /var/www/html/
	sudo usermod -a -G root danny
	sudo service vsftpd restart
````


### Filezilla auf dem HOST installieren
````ps

	https://www.heise.de/download/product/filezilla-18785/download/danke?id=6e520316-e188-4944-9531-92147782457c
````
.

.

### nodejs installieren


##
````ps

    sudo yum install nodejs -y
````

.
````ps

    sudo mdir -p/var/app/
````

.
````ps

    cd /var/app
````
.
````ps

    cd ..
````

.
````ps

    sudo wget https://aws-tc-largeobjects.s3-us-west-2.amazonaws.com/ILT-TF-100-TECESS-5/app/app.zip
````
.
````ps

    sudo unzip app.zip -d /var/app/
````
.
````ps

    cd  /var/app/
    sudo npm install -y
````
.
````ps

    cd ..
````
.
````ps

    cd var/app/api/common/
````

.
````ps

    sudo nano constants.js
````
.


## ![Constant-File](../AWS-Beginner/AWS/screens/KW23/constants.js.png)


.
````ps
	sudo npm start
````
.

-	Elemente in AWS erstellen damit die gleichen Attribute angelegt sind!

## ![EmployeerTable](../AWS-Beginner/AWS/screens/KW23/AWS%20-%20employeerManagementTable.png)

````ps

````



## JSON - Datei für das s3-Bucket 
-	wenn wir eine Mitarbeiter Tabelle im s3 Bucket erstellen wollen brauchen wir: 
	-	Berechtigungsrolle mit EC2 Anbindung	 
	-	s3-Bucket 
	-	bestimmte Richtlinie
	-	Management-Console (WebAPI) von AWS
	-	Tabelle erstellen mit den Namen von der constants.js
	-	Schlüsselpaare anlegen und verbinden

.
````json 
JSON File für s3 Bucket
{   "Version": "2024-06-04",
    "Statement": [
        {
            "Effect": "Allow",
            "Action":
			[ 
				"s3:ListAllMyBuckets",
				"s3:ListBucket",
				"s3:GetObject",
				"s3:DeleteObject"
			],
            "Resource":
			[
				"arn:aws:s3:::s3danny",
				"arn:aws:s3:::s3danny/*",
				"arn:aws:s3:::*"
			]
        }
    ]
}
````

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


