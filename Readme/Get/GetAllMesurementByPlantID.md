# GetAllMesurementByPlantID

**URL** : `​​​/api​/Measurements​/GetAllMesurementByPlantID`

**Method** : `GET`

**Auth required** : NO

**Permissions required** : None

## Parameters
* plantID

### Example URL
```
/api/Measurements/GetAllMesurementByPlantID?plantID=1
```

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
  },
  {
    "plantID": 1,
    "plantName": "Bodur çeri",
    "plantHeight": 1,
    "typeName": "Tomatoes",
    "airQuality": 11,
    "airTemperature": 11,
    "airHumidity": 11,
    "soilTemperature": 11,
    "soilHumidity": 11,
    "createdDate": "2021-09-13T00:00:00"
  },
  {
    "plantID": 1,
    "plantName": "Bodur çeri",
    "plantHeight": 1,
    "typeName": "Tomatoes",
    "airQuality": 10,
    "airTemperature": 10,
    "airHumidity": 10,
    "soilTemperature": 10,
    "soilHumidity": 10,
    "createdDate": "2021-09-13T00:00:00"
  }
]
```