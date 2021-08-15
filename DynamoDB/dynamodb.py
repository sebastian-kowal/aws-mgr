import boto3
import uuid

table_name = 'db-items'

dynamodb = boto3.resource('dynamodb')

table = dynamodb.Table(table_name)

def get_items():
    response = table.scan()
    
    items = response['Items']
    
    for item in items:
        print(item['ItemId'])
  
def insert_items(item_count):
    for i in range(item_count):
        table.put_item(Item={
            'ItemId': str(uuid.uuid4()),
            'Name': 'my-item {0}'.format(str(i))
        })

# Main
insert_items(10)

get_items()
