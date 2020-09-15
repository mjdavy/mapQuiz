docker build -t mapquiz .
docker login
docker tag mapquiz mjdavy/mapquiz
docker push mjdavy/mapquiz
