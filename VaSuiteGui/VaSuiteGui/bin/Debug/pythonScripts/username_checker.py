# -*- coding: utf-8 -*-
import json
import urllib.request
import urllib.error
import sys

# Komut satýrýndan argüman oku
if len(sys.argv) < 2:
    print("Username cannot be empty.")
    exit()

username = sys.argv[1].strip()

if not username:
    print("Username cannot be empty.")
    exit()

# JSON dosyasýný oku
with open("req/site_list.json", "r", encoding="utf-8") as file:
    site_list = json.load(file)

# Sitelerde kullanýcý adý kontrolü
for site in site_list:
    url = site["url"].replace("%s", username)
    try:
        with urllib.request.urlopen(url) as response:
            if response.status == 200:
                print(f"[+] Bulundu: {site['name']} -> {url}")
    except urllib.error.HTTPError:
        print(f"[-] Yok: {site['name']}")
    except urllib.error.URLError as e:
        print(f"[!] Hata: {site['name']} Connection failed ({e.reason})")
