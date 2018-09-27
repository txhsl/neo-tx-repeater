# neo-tx-repeater

This is a program to produce duplicated transactions between 2 wallets to create UTXO data for testing usage.

## usage

Use with neo-cli-docker which provide a private net on docker, or just pull from txhsl/neo-cli-docker.

Use the config file in ./sample, config.json and protocol.json, to connect the private net and claim NEO and GAS.

Create 2 new wallets and give each about 500 NEO and start the repeater.

The password for all the wallets are 11111111.

## sample

Pull a docker image from txhsl/neo-cli-docker-fulldata

Use the wallet file in ./sample, new1.json and new2.json, to open 2 NEP6 wallets with 20k transactions each.

## warning

Only json wallet tested.
