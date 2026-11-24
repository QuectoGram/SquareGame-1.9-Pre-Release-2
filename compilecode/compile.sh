#!/bin/bash
g++ main.cpp -o SquareGame1.9PreRel -lraylib -lGL -lm -lpthread -ldl -lrt -lX11 -lyaml-cpp
read -n 1 -s -r -p "Press any key to continue..."
echo ""
