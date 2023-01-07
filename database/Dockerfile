FROM postgres:12.3

COPY init.sql /docker-entrypoint-initdb.d/

ENV POSTGRES_DB=project
ENV POSTGRES_USER=postgres
ENV POSTGRES_PASSWORD=password