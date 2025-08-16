# -*- coding: utf-8 -*-
import json
import os
import sys
import urllib.request
import urllib.error

def check_username(username):
    script_dir = os.path.dirname(os.path.abspath(__file__))
    json_path = os.path.join(script_dir, "req", "site_list.json")  # site_list.json yolunu ayarla
    results = {"found": [], "not_found": [], "errors": []}

    try:
        with open(json_path, "r", encoding="utf-8") as file:
            site_list = json.load(file)
    except Exception as e:
        results["errors"].append(f"JSON okuma hatasý: {str(e)}")
        return json.dumps(results)

    for site in site_list:
        raw_url = site["url"]
        if not raw_url.startswith(("http://", "https://")):
            results["errors"].append(f"Geçersiz URL: {site['name']}")
            continue
        if "%s" not in raw_url:
            results["errors"].append(f"URL'de %s yok: {site['name']}")
            continue

        url = raw_url.replace("%s", username)
        try:
            with urllib.request.urlopen(url) as response:
                if response.status == 200:
                    results["found"].append({"name": site["name"], "url": url})
        except urllib.error.HTTPError:
            results["not_found"].append(site["name"])
        except urllib.error.URLError as e:
            results["errors"].append(f"{site['name']} baðlantý hatasý: {e.reason}")

    return json.dumps(results)

if __name__ == "__main__":
    if len(sys.argv) < 2:
        print(json.dumps({"error": "Kullanýcý adý boþ olamaz."}))
        sys.exit(1)
    
    username = sys.argv[1].strip()
    print(check_username(username))