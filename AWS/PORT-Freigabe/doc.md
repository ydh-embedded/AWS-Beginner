# Port freigabe

- funtkioniert aktuell nicht mit der Amazon AWS Distribution !!!

## wget install
-
	    sudo yum install wget

## To open port 4567 
- in Amazon Arch Linux, you can use the firewall-cmd command. Here's an example command to open the port:

	    sudo firewall-cmd --add-port=4567/tcp --permanent

## To install ufw
- (Uncomplicated Firewall) on Amazon Linux, you can use the yum package manager with the following command:

	    sudo yum install ufw

## To install awscli
- (AWS Command Line Interface) on Amazon Linux, you can use the pip package manager with the following command:

	    sudo pip install awscli

## Yes, it is possible to install ufw on Amazon Linux using an alternative installer.
- You can download the ufw RPM package from the EPEL repository and install it using the rpm command. Here's an example command to install ufw:

	
	sudo rpm -ivh https://dl.fedoraproject.org/pub/epel/7/x86_64/u/ufw-0.36-1.el7.x86_64.rpm