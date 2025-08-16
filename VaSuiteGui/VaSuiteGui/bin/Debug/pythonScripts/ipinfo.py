
# -*- coding: utf-8 -*-


import sys
import requests

def get_ip_info(ip_address):
    token = "b3a1fbca8abb3e"
    url = f"http://ipinfo.io/{ip_address}/json?token={token}"




    try:
        response = requests.get(url)
        data = response.json()

        print(f"IP Adresi: {data.get('ip')}")
        print(f"Konum: {data.get('city')}, {data.get('region')}, {data.get('country')}")
        print(f"geo coordinate: {data.get('loc')}")
        print(f"ISP: {data.get('org')}")
    except requests.exceptions.RequestException as e:
        print("Hata oluştu: {}".format(e))

if __name__ == "__main__":
    if len(sys.argv) < 2:
        print("Lütfen bir IP adresi girin.")
    else:
        ip = sys.argv[1]
        get_ip_info(ip)
