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

