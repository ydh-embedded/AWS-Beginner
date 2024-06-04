
#   S3

````json

{
	"Version": "2012-10-17",
	"Statement": [
		{
			"Sid": "PublicReadGetObject",
			"Effect": "Allow",
			"Principal": "*",
			"Resource": ["arn:aws:s3:::dannys-s3-bucket-on-ec2/*"],
			"Action": ["s3:GetObject"]
		}
	]
}
```