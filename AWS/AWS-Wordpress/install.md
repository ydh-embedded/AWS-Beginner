### 1-
````ps
        sudo yum install mysql -y
````
### 2-
````ps
        export MYSQL_HOST=Endpunkt
````
### 3-
````ps
        mysql -u username -p db_name
````
### 4-
````ps
        CREATE USER 'wp-admin' IDENTIFIED BY 'Pa$$w0rd';
````
### 5-
````ps
        GRANT ALL PRIVILEGES ON wp.* TO 'wp-admin';
````
### 6-
````ps
        sudo yum install httpd -y
````
### 7-
````ps
        sudo service httpd start
````
### 8-
````ps
        wget https://wordpress.org/latest.tar.gz
````
### 9-
````ps
        tar -xzf latest.tar.gz
````
### 10
````ps
        -cp wp-config-sample.php wp-config.php
````
### 11
````ps
        -nano wp-config.php
````
### 12
````ps
        -sudo nano wp-config.php
````
### 13 API CODE
````ps
        -https://api.wordpress.org/secret-key/1.1/salt/
````
### 14
````ps
        -sudo amazon-linux-extras install -y lamp-mariadb10.2-php7.2 php7.2
````

### 15
````ps
        -sudo cp -r wordpress/* /var/www/html/
````
### 16
````ps
        -sudo service httpd restart
````
### 17
````ps
        -sudo chkconfig httpd on
````