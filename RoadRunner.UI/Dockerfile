# Stage 1
FROM node:14.18.1-alpine as drr_ui_base
RUN npm install @angular/cli@12.2.0 -g

# Stage 2
FROM drr_ui_base as drr_ui_packages
RUN mkdir /app
WORKDIR /app
# add `/app/node_modules/.bin` to $PATH
ENV PATH /app/node_modules/.bin:$PATH
# install project level dependencies
COPY package.json /app/package.json
RUN npm install -g cross-env
RUN npm install


# Stage 3
FROM drr_ui_packages as drr_ui_build
COPY . /app
RUN ng build --output-path=dist

# Stage 4
FROM nginx:1.16.0-alpine as drr_ui_server
#
COPY --from=drr_ui_build /app/dist /usr/share/nginx/html
#COPY nginx/config/nginx_aws_prod.conf /etc/nginx/nginx.conf
#COPY nginx/cert /etc/nginx/certs
#
EXPOSE 80
#
# Containers run nginx with global directives and daemon off
CMD ["nginx", "-g", "daemon off;"]

