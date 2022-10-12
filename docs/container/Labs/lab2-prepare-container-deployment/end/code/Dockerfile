FROM node:18-alpine3.15

# Create app directory
WORKDIR /usr/src/app

# Copy solution package file
COPY package*.json ./

# Install app dependencies
RUN npm install

# Copy all files
COPY . .

# Add command to expose web app port 
EXPOSE 3000

# Command to start the application
CMD [ "npm", "start" ]