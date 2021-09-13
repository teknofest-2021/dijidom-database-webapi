# GetLastMeasurement

**URL** : `​​/api​/Measurements​/GetLastMeasurement`

**Method** : `GET`

**Auth required** : NO

**Permissions required** : None

## Success Response

**Condition** : If everything is OK and Server is UP.

**Code** : `200 SUCCESSFUL`

**Content Example**

```json
[
  {
    "plantID": 1,
    "plantName": "Bodur çeri",
    "plantHeight": 1,
    "typeName": "Tomatoes",
    "airQuality": 13,
    "airTemperature": 13,
    "airHumidity": 13,
    "soilTemperature": 13,
    "soilHumidity": 13,
    "createdDate": "2021-09-13T00:00:00"
  }
]
```