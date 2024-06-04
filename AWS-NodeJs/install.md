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


