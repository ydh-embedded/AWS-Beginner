# AWS Project

## HustenSaftSchmuggler







### Internal-Weimar-HTML

- Amazon-Ressourcenname (ARN) s3ofwordpress
	arn:aws:s3:::s3ofwordpress
- IAM -> Richtlinie -> JSON
````json
{
	"Version": "2012-10-17",
	"Statement": [
		{
			"Sid": "Statement1",
			"Effect": "Allow",
			"Action": ["s3:ListAllMyBuckets" , "s3:ListBucket" , "s3:GetObject" , "s3:DeleteObject"],
			"Resource": ["arn:aws:s3:::s3ofwordpress" , "arn:aws:s3:::s3ofwordpress/*" , "arn:aws:s3:::s3ofwordpress"]
		}
	]
}
````

- Instance-ID

	i-0b15725b6ade2ca38 (Internal-Weimar-HTML)

- Öffentliche IPv4-Adresse

	18.153.97.226 | offene Adresse 









### AutoScalingGroup-Weimar


- Instance
	i-0bd1f8f9ba6d9aad1

- Öffentliche IPv4
	http://18.198.147.212

- Hostname-Typ
	IP-Name: ip-172-21-1-177.eu-central-1.compute.internal











### Wordpress

````php

//** Database settings - You can get this Info from your web host**//

/** The name of the database for Wordpress */
define ( 'DB_NAME' , 'DB_WordPress_HustenSaftSchmuggler');

/** Database username */
define ( 'DB_USER' , 'root' );

/** Database password */
define ( 'DB_PASSWORD' , 'Pa$$w0rd' );

/** Database Hostname */
define ( 'DB_HOST' , 'db-aws-machine-wordpress. (...) .rds.amazon.com' );

/** Database Charset to use in creating database tables. */
define ( 'DB_CHARSET' , 'utf8' );

/** Database collate type. Dont change this if in doubt. */
define ( 'DB_CHARSET' , '' );



````

````php

define('AUTH_KEY',         'eKt<&E0o!v:[|e]][0++|f^i|U&{l}Y+{2yhw2<>//7C.ghOU#(y.~hHeWsKZ/ak');
define('SECURE_AUTH_KEY',  'N5 4//kfI<ha(F0urI(e$`=xi{9.:g+$]v|z(LP+=l^MU%g,v/ORobhJY9cRe_uw');
define('LOGGED_IN_KEY',    '/~/OOChW]]43&[6kPRq>j+srH,Te@ZJ>&<X2CROZ}RFr9~W2-c&_=-He.CErkB?2');
define('NONCE_KEY',        'z*>p1t1wGc&Arc6:I%*z7*mE%?ZSdq<[BD*ntf;-nZ<QsK?)n<bqp<+^#vQI8;@@');
define('AUTH_SALT',        'V/E=)it@|E{/DARnarQ|fU-{BiyW+<`!OXnb|y&vKZL?9|xiQ+{5=vwM>:|BIk~_');
define('SECURE_AUTH_SALT', 'ZlRR>}_:ouMS7[0A`FE0T,zqoW4tfwu#!w|=?7L&rByFKdmmAl5jt|[a2oDO|l}i');
define('LOGGED_IN_SALT',   'JokRz`P,0InCMfee*^C?yV^G1IC|Z-QC09Q/``UHJqhNW{`14rG1/)}b4Q,_N9!_');
define('NONCE_SALT',       'o<&AQE?wgCrJMHO|vUc VI6Z}qko8|#-VWOwezZ_|+-]LH&??A(@{d/x.v-*/_pL');

````