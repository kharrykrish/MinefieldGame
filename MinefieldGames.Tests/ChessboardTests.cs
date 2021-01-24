using MinefieldGame.GameLogic;
using MinefieldGames.Tests.MockObjects;
using System;
using Xunit;

namespace MinefieldGames.Tests
{
    public class ChessboardTests
    {
      
        [Fact]
        public void ItShouldSetBoardGetTheCurrentPositions()
        {
            int boardWidth = 8, boardHeight = 8;
            var board = new Chessboard(new MockDisplay());
            board.Setup(boardWidth, boardHeight);
            var activeTile = board.GetActiveTile();
            var finishTile = board.GetFinishedTile();

            Assert.Equal(typeof(Tile), activeTile.GetType());
            Assert.Equal(0, activeTile.GetYPosition());
            Assert.True(activeTile.GetXPosition() >= 0 && activeTile.GetXPosition() < boardWidth);

            Assert.Equal(typeof(EndTitle), finishTile.GetType());
            Assert.Equal(boardHeight - 1, finishTile.GetYPosition());
            Assert.True(finishTile.GetXPosition() >= 0 && finishTile.GetXPosition() < boardWidth);
        }

       
        [Fact]
        public void ItShouldGenerateChessesTilesCorrectly()
        {
            var tiles = new Chessboard(new MockDisplay()).GenerateTiles(8, 8);

            Assert.Equal("A1", tiles[0, 0].GetId());
            Assert.Equal("H8", tiles[7, 7].GetId());
            Assert.Equal("D5", tiles[3, 4].GetId());
            Assert.Equal(8, tiles.GetLength(0));
            Assert.Equal(8, tiles.GetLength(1));
        }

   
        [Fact]
        public void ItShouldGenerateEndTileForB()
        {
            var boardHeight = 8;
            var tile = new Chessboard(new MockDisplay()).GenerateFinishTile(1, boardHeight);

            Assert.Equal(typeof(EndTitle), tile.GetType());
            Assert.Equal("B8", tile.GetId());
        }

      
        [Fact]
        public void ItShouldResturnToStartPointAfterRound()
        {
            int boardWidth = 8, boardHeight = 8;

            var board = new Chessboard(new MockDisplay());

            board.Setup(boardWidth, boardHeight);

            board.SetActiveTile(0,0);
            Assert.True(board.GetActiveTile().GetId() == "A1");

            board.MoveTileRight();
            Assert.True(board.GetActiveTile().GetId() == "B1");
          

            board.MoveTileUp();
            Assert.True(board.GetActiveTile().GetId() == "B2");
           
            board.MoveTileLeft();
          
            Assert.True(board.GetActiveTile().GetId() == "A2");

            board.MoveTileDown();
          
            Assert.True(board.GetActiveTile().GetId() == "A1");
        }
    }
}
