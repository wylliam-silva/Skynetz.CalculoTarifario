<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Skynetz.CalculoTarifario._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cauculadora de Tarifa</h1>
        <p class="lead">Utilize nossa calculadora abaixo para calcular as tarifas do nosso plano "Fale Mais" e descubra qual se encaixa melhor no seu orçamento!</p>

            <div class="form-group">
                <label for="selectOrigem  form-select-lg mb-3">Origem:</label>
                <select runat="server" class="form-select" id="idOrigem" onchange="onChangeOrigem()">
                  <option selected value="1">011</option>
                  <option value="2">016</option>
                  <option value="3">017</option>
                  <option value="4">018</option>
                </select>
            </div>

            <div class="form-group">
                <label for="selectDestino">Destino:</label>
                <select runat="server" class="form-select  form-select-lg mb-3" id="idDestino">
                  <option id="id011Destino" selected value="1">011</option>
                  <option value="2">016</option>
                  <option value="3">017</option>
                  <option value="4">018</option>
                </select>
            </div>

            <div class="form-group">
                <label for="inputMinutos">Minutos:</label>
                <input runat="server" type="number" class="form-control" id="idMinutos" min="0" placeholder="Duração das chamadas em minutos" value="0">
            </div>

            <div class="form-group">
                <label for="selectPlano">Plano:</label>
                <select class="form-select  form-select-lg mb-3" id="idPlano" runat="server">
                  <option  selected value="30">Fale Mais 30</option>
                  <option value="60">Fale Mais 60</option>
                  <option value="120">Fale Mais 120</option>
                </select>
            </div>

            <p>
                <asp:Button class="btn btn-success btn-lg" id="InsertButton" onclick="InsertButton_Click" runat="server" text="Calcular"/>
            </p>

            <table class="table table-striped" id="idTabelaResultado" runat="server" visible="false">
                <thead>
                    <tr>
                      <th>Origem</th>
                      <th>Destino</th>
                      <th>Tempo</th>
                      <th>Plano FaleMais</th>
                      <th>Com Plano FaleMais</th>
                      <th>Sem Plano FaleMais</th>
                    </tr>
                </thead>
  ...           <tbody>
                    <tr>
                        <th runat="server" id="idOrigemResultado"></th>
                        <th runat="server" id="idDestinoResultado"></th>
                        <th runat="server" id="idTempoResultado"></th>
                        <th runat="server" id="idPlanoFaleMaisResultado"></th>
                        <th runat="server" id="idComPlanoFaleMaisResultado"></th>
                        <th runat="server" id="idSemPlanoFaleMaisResultado"></th>
                    </tr>
                </tbody>
            </table>
    </div>


</asp:Content>
