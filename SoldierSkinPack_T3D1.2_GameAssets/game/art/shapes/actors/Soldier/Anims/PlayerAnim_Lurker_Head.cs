singleton TSShapeConstructor(PlayerAnim_Lurker_HeadDAE)
{
   baseShape = "./PlayerAnim_Lurker_Head.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "900", "910");
}
