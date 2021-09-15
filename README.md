# DIJI-DOM DATABASE RESTAPIDocs

This repostory is about [DİJİ-DOM Database WEBAPI](https://github.com/teknofest-2021/dijidom-database-webapi) and so the api will return
JSON responses.

Where full URLs are provided in responses they will be rendered as if service is running on 'http://194.31.79.154:6068'.

## Open Endpoints

Open endpoints require no Authentication.
Each endpoint manipulates or displays information related to dijidom database the which provided:

### GET
* [GetAmbients](Readme/Get/GetAmbients.md): `/api/Ambients/GetAmbient` 
* [GetPlants](Readme/Get/GetPlants.md): `/api/Plants/GetPlants`
* [GetPlantTypes](Readme/Get/GetPlantTypes.md): `/api/Plants/GetPlantTypes`
* [GetSoils](Readme/Get/GetSoils.md): `/api/Plants/GetSoils`
* [GetLastMeasurement](Readme/Get/GetLastMeasurement.md): `/api/Measurements/GetLastMeasurement`
* [GetAllMeasurementByPlantID](Readme/Get/GetAllMeasurementByPlantID.md): `​/api​/Measurements​/GetAllMeasurementByPlantID`

### POST
* [CreateMeasurement](Readme/Post/CreateMeasurement.md): `​/api​/Measurements​/CreateMeasurement`
* [UpdatePlantHeight](Readme/Post/UpdatePlantHeight.md): `​/api​/Plants​/UpdatePlantHeight`

## Built with

* [.Net 5.0](https://dotnet.microsoft.com/) - The backend
* [VsCode](https://code.visualstudio.com/) - Visual Studio Code
* [PostgreSQL](https://www.postgresql.org/) - For database.
* No external libraries were used in this project

## Authors

* **Ramazan Kaan Yarayan** - [Github](https://github.com/rknyryn)
* **Fehmi Şener** - [Github](https://github.com/fehmiisener)

See also the list of [contributors](https://github.com/teknofest-2021/dijidom-database-api) who participated in this project.

## Acknowledgments

* Dear Teachers
* Teknofest Executives
* All Team Members
