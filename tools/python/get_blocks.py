import requests
import json

#url = 'http://192.168.0.27:8888/api/Monitor/GetWalletData/GetWalletData'
#url = 'http://apinode.credits.com/api/Monitor/GetWalletData/GetWalletData'
url =  'http://localhost:60476/api/Monitor/GetBlocks'
#url =  'http://169.63.5.243:5006/api/Monitor/GetBlocks'
#url =  'http://localhost:60476/api/Monitor/GetWalletData'

headers = {
    'Content-type': 'application/json'
    , 'Accept': 'application/json'
    , 'Content-Encoding': 'utf-8'
    }

data = {
    "authKey": "87cbdd85-b2e0-4cb9-aebf-1fe87bf3afdd"
    #, "PublicKey":"5B3YXqDTcWQFGAqEJQJP3Bg1ZK8FFtHtgCiFLT5VAxpe"
    , "NetworkAlias":"MainNet"
    #, "networkIp":"165.22.212.41"	# = TestNet
    #, "networkPort":"9070"         # = TestNet
    #, "networkIp":"195.133.73.36"	# vh4 mainnet
    #, "networkIp":"165.22.242.197"	# do-lon4 testnet
    #, "networkPort":"9070"
	#, "ConsensusInfo":True
	, "Transactions":True
	#, "ContractsApproval":True
	#, "Signatures":True
	#, "Hashes":True
	, "BeginSequence":239
	, "EndSequence":239
    }

answer = requests.post(url, data=json.dumps(data), headers=headers)

print(answer)
if answer.status_code == 200:
    response = answer.json()
    print(response)
    text_file = open("sample.json", "w")
    print(response, file=text_file, flush=True)
    #n = text_file.write(response)
    text_file.close()