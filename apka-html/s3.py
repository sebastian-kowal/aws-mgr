import boto3

s3 = boto3.client('s3')

s3_response = s3.list_buckets()

buckets = s3_response['Buckets']

for bucket in buckets:
    print(bucket['Name'])
