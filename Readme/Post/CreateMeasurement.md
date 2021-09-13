# CreateMeasurement

Push Data which came from RasperyPI to Database

**URL** : `/api​/Measurements​/CreateMeasurement`

**Method** : `POST`

**Auth required** : NO

**Permissions required** : None

**Data Example** All fields must be sent.

```json
{
  "measurementDate": "2021-09-13T12:23:12.533Z",
  "plantID": 1,
  "soilHumidity": 10,
  "soilTemperature": 0,
  "airQuality": 0,
  "airTemperature": 0,
  "airHumidity": 0
}
```

## Success Response

**Condition** : If everything is OK and Server is UP.

**Code** : `200 SUCCESSFUL`

**Content Example**

```json
{
  "data": {
    "measurementDate": "2021-09-13T12:23:12.533Z",
    "plantID": 1,
    "soilHumidity": 13,
    "soilTemperature": 13,
    "airQuality": 13,
    "airTemperature": 13,
    "airHumidity": 13
  },
  "message": "Successfully written to database"
}
```

## Error Responses

**Condition** : If any database error. (May caused by dataString)

**Code** : `200 SUCCESSFUL`

```json
{
  "data": {
    "measurementDate": "2021-09-13T12:30:06.389Z",
    "plantID": 0,
    "soilHumidity": 0,
    "soilTemperature": 0,
    "airQuality": 0,
    "airTemperature": 0,
    "airHumidity": 0
  },
  "message": "Could not write to database. An error occurred while updating the entries. See the inner exception for details."
}
```