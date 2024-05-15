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

	
	sudo  yum install mySQL -y
### Zuweisung der Datenbank zur Machine

	export MYSQL_HOST=db-dannys-aws-machine.ctfu1ip0w6hu.eu-central-1.rds.amazonaws.com.

### DB Anmeldung mit dem User root

	mysql -u root -p dannysWordpress

