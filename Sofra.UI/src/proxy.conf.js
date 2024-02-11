const PROXY_CONFIG = [
  {
    context: [
      "/reservation",
    ],
    target: "https://localhost:5001",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
