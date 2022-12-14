FROM node:18.12-alpine3.17

# Create app directory
WORKDIR /usr/src/app
RUN apk update
# Copy solution package file
COPY package*.json ./

# Install app dependencies
RUN npm install
RUN npm audit fix --force
# Copy all files
COPY . .

# Add command to expose web app port 
EXPOSE 3000

# Command to start the application
CMD [ "npm", "start" ]