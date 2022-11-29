---
# Page settings
layout: default
keywords: Azure AppSource Marketplace SaaS
comments: false

hide:
  - navigation
---

# Marketplace Bot Proof of Concept

<style>
  html, body {
      height: 100%;
  }
  body {
      margin: 0;
  }
  h1 {
      font-size: 16px;
      font-family: Segoe UI;
      line-height: 20px;
      color: whitesmoke;
      display: table-cell;
      padding: 13px 0px 0px 20px;
  }
  .heading {
      background-color: black;
      height: 50px;
  }
  .main {
      margin: 18px;
      border-radius: 4px;
  }

  div[role="form"]{
      background-color: black;
  }
  #webchat {
      position: fixed;
      height: calc(100% - 50px);
      width: 100%;
      top: 50px;
      overflow: hidden;
  }
</style>

<iframe 
    src="https://web.preview.powerva.microsoft.com/environments/839eace6-59ab-4243-97ec-a5b8fcc104e4/bots/new_bot_26502aa7d017484a9307e0f09788f489/webchat"
    frameborder="1"
    style="width: 100%; height: 600px;">
</iframe>

<script src="https://cdn.botframework.com/botframework-webchat/latest/webchat.js"></script>
<script>
    const styleOptions = {
        // Add styleOptions to customize web chat canvas
        hideUploadButton: true
    };

    console.debug("Got it");

    // Add your BOT ID below
    var BOT_ID = "b11ecfe8-48ef-4d5c-a77b-ee24c5c245a0";

    var theURL = "https://powerva.microsoft.com/website/bots/" + BOT_ID;

    const store = window.WebChat.createStore(
        {},
        ({ dispatch }) => next => action => {
            if (action.type === "DIRECT_LINE/CONNECT_FULFILLED") {
              dispatch({
                  meta: {
                        method: "keyboard",
                    },
                    payload: {
                        activity: {
                              channelData: {
                                  postBack: true,
                              },
                              //Web Chat will show the 'Greeting' System Topic message which has a trigger-phrase 'hello'
                              name: 'startConversation',
                              type: "event"
                          },
                    },
                    type: "DIRECT_LINE/POST_ACTIVITY",
                });
          }
          return next(action);
      }
    );
    fetch(theURL)
        .then(response => response.json())
        .then(conversationInfo => {
            window.WebChat.renderWebChat(
                {
                    directLine: window.WebChat.createDirectLine({
                        token: conversationInfo.token,
                    }),
                    store: store,
                    styleOptions: styleOptions
                },
                document.getElementById('webchat')
            );
        })
        .catch(err => console.error("An error occurred: " + err));
</script>