./auth.sh;
cd ../../EntityFramework || exit ;
./auth-ef.sh;

cd ../Docker/Production || exit ;

./collections.sh;
cd ../../EntityFramework || exit ;
./collections-ef.sh;

cd ../Docker/Production || exit ;

./glimpses.sh;
cd ../../EntityFramework || exit ;
./glimpse-ef.sh;

cd ../Docker/Production || exit ;

./ingress.sh;

./keycloak-service.Production.sh;

./profiles-service.Production.sh;
cd ../../EntityFramework || exit ;
./profile-ef.sh;

cd ../Docker/Production || exit ;

./reactions.sh;
cd ../../EntityFramework || exit ;
./reactions-ef.sh;

cd ../Docker/Production || exit ;

./recipes.sh;
cd ../../EntityFramework || exit ;
./recipe-ef.sh;

cd ../Docker/Production || exit ;

./seaweed-fs.sh;

./reactions.sh;
cd ../../EntityFramework || exit ;
./reactions-ef.sh;

cd ../Docker/Production || exit ;

./subscriptions-service.Production.sh;
cd ../../EntityFramework || exit ;
./subscriptions-ef.sh;

cd ../Docker/Production || exit ;

./tags.sh;
cd ../../EntityFramework || exit ;
./tag-ef.sh;

cd ../Docker/Production || exit ;
